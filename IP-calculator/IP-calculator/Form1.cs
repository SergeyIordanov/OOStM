using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IP_calculator
{
    public partial class Form1 : Form
    {
        string netAddress = "0.0.0.0";
        string mask = "255.255.255.0";

        public Form1()
        {
            InitializeComponent();
            labelIPError.Text = "";
            labelMaskError.Text = "";
            fillBits(true);
        }

        #region Events

        private void textBoxIP_TextChanged(object sender, EventArgs e)
        {
            TextBox current = sender as TextBox;
            TextBox next;
            if (current.Name.Equals("textBoxIP1")) next = textBoxIP2;
            else if (current.Name.Equals("textBoxIP2")) next = textBoxIP3;
            else if (current.Name.Equals("textBoxIP3")) next = textBoxIP4;
            else next = textBoxIP4;

            if (current.Text.Length >= 3)
            {
                current.Text = current.Text.Substring(0, 3);
                textBoxIP1.Focus();
                next.Focus();
            }
            netAddress = textBoxIP1.Text + "." + textBoxIP2.Text + "." + textBoxIP3.Text + "." + textBoxIP4.Text;
            if (validateIP()) culcResults();
            else dropResults();
        }
        
        private void textBoxMask_TextChanged(object sender, EventArgs e)
        {
            TextBox current = sender as TextBox;
            TextBox next;
            if (current.Name.Equals("textBoxMask1")) next = textBoxMask2;
            else if (current.Name.Equals("textBoxMask2")) next = textBoxMask3;
            else if (current.Name.Equals("textBoxMask3")) next = textBoxMask4;
            else next = textBoxMask4;

            if (current.Text.Length > 3)
            {
                current.Text = current.Text.Substring(0, 3);
                textBoxMask1.Focus();
                next.Focus();
            }
            mask = textBoxMask1.Text + "." + textBoxMask2.Text + "." + textBoxMask3.Text + "." + textBoxMask4.Text;
            if (validateMask()) culcResults();
            else dropResults();
        }

        #endregion

        #region Validation
        private bool validateIP()
        {       
            labelIPError.Text = "";

            if (!Regex.IsMatch(netAddress, @"^(25[0-5]|2[0-4][0-9]|[0-1][0-9]{2}|[0-9]{2}|[0-9])(\.(25[0-5]|2[0-4][0-9]|[0-1][0-9]{2}|[0-9]{2}|[0-9])){3}$"))
            {
                labelIPError.Text = "Invalid address";
                return false;
            }
            return true;
        }    

        private bool validateMask()
        {
            labelMaskError.Text = "";

            string values = "(0|00|000|128|192|224|240|248|252|254|255)";
            string valuesLast = "(0|00|000|128|192|224|240|248|252)";
            string zero = "(0|00|000)";
            if (!Regex.IsMatch(mask, String.Format(@"^({0}\.{1}\.{1}\.{1})|(255\.{0}\.{1}\.{1})|(255\.255\.{0}\.{1})|(255\.255\.255\.{2})$", values, zero, valuesLast)))
            {
                labelMaskError.Text = "Invalid mask";
                return false;
            }
            return true;
        }

        #endregion

        #region Culc & drop results
        private void dropResults()
        {
            numericUpDownSubnets.Maximum = 2;
            buttonDivide.Enabled = false;
            labelIPBits.Text = "0000 0000.0000 0000.0000 0000.0000 00000";
            labelMaskBits.Text = "0000 0000.0000 0000.0000 0000.0000 00000";
            labelNetwork.Text = "0.0.0.0";
            labelNode.Text = "null";
            labelBitmask.Text = "0";
            labelMinHost.Text = "0.0.0.0";
            labelMaxHost.Text = "0.0.0.0";
            labelHosts.Text = "0";
            labelBroadcast.Text = "0.0.0.0";
            labelMaxSubnets.Text = "(max: 0)";
            fillBits(false);
        }      

        private void culcResults()
        {
            buttonDivide.Enabled = true;
            fillBits(true);
            labelNetwork.Text = culcNetwork();           
            labelHosts.Text = culcHosts();
            labelNode.Text = culcNodeNum();
            labelBitmask.Text = culcBitmask();
            labelMinHost.Text = culcMinHost();
            labelMaxHost.Text = culcMaxHost();
            labelBroadcast.Text = culcBroadcast();
            labelMaxSubnets.Text = "(max: " + culcSubnets() + ")";
            numericUpDownSubnets.Maximum = Convert.ToInt32(culcSubnets());

            fillBits(true);
        }

        private string culcSubnets()
        {
            string binM = labelMaskBits.Text.Replace(" ", String.Empty).Replace(".", String.Empty);
            long maskBin = Convert.ToInt32(binM, 2);
            long res = ((~maskBin) >> 1) + 1;
            return res.ToString();
        }

        private string culcMinHost()
        {
            string[] networkArr = labelNetwork.Text.Split('.');
            int last = Convert.ToInt32(networkArr[3]) + 1;
            string res = "";
            for(int i = 0; i < networkArr.Length-1;i++)
            {
                res += networkArr[i] + ".";
            }
            res += last.ToString();
            return res;
        }
        private string culcBroadcast()
        {
            string[] maskArr = mask.Split('.');
            string[] netArr = labelNetwork.Text.Split('.');
            string res = "";
            int tempNet, tempMask;
            for (int i = 0; i < maskArr.Length; i++)
            {
                tempNet = Convert.ToInt32(netArr[i]);
                tempMask = Convert.ToInt32(maskArr[i]);
                res += ((tempNet | (~tempMask)) + 256).ToString();
                if (i < 3)
                    res += ".";
            }
            return res;
        }

        private string culcMaxHost()
        {
            string[] maskArr = mask.Split('.');
            string[] netArr = labelNetwork.Text.Split('.');
            string res = "";
            int tempNet, tempMask;
            for (int i = 0; i < maskArr.Length; i++)
            {
                tempNet = Convert.ToInt32(netArr[i]);
                tempMask = Convert.ToInt32(maskArr[i]);
                if (i < 3)
                    res += ((tempNet | (~tempMask)) + 256).ToString() + ".";
                else
                    res += ((tempNet | (~tempMask)) + 255).ToString();
            }
            return res;
        }

        private string culcHosts()
        {
            string binM = labelMaskBits.Text.Replace(" ", String.Empty).Replace(".", String.Empty);
            long maskBin = Convert.ToInt32(binM, 2);
            long res = (~maskBin) - 1;
            return res.ToString();
        }

        private string culcBitmask()
        {
            int res = 0;
            string binM = labelMaskBits.Text.Replace(" ", String.Empty).Replace(".", String.Empty);
            foreach (char ch in binM)
                if (ch == '1')
                    res++;
            return res.ToString();
        }

        private string culcNodeNum()
        {
            string binM = labelMaskBits.Text.Replace(" ", String.Empty).Replace(".", String.Empty);
            string binA = labelIPBits.Text.Replace(" ", String.Empty).Replace(".", String.Empty);
            long maskBin = Convert.ToInt32(binM, 2);
            long addressBin = Convert.ToInt32(binA, 2);
            long res = ((~maskBin) & addressBin);

            if (res.ToString().Equals("0"))
                return "null (network address)";
            else if ((res-1).ToString().Equals(labelHosts.Text))
                return "null (broadcast address)";

            return res.ToString();
        }

        private string culcNetwork()
        {
            string[] addressArr = netAddress.Split('.');
            string[] maskArr = mask.Split('.');
            string res = "";
            int tempAdr, tempMask;
            for(int i = 0; i < addressArr.Length; i++ )
            {
                tempAdr = Convert.ToInt32(addressArr[i]);
                tempMask = Convert.ToInt32(maskArr[i]);
                res += (tempAdr & tempMask).ToString();
                if (i < 3)
                    res += ".";
            }
            return res;
        }

        #endregion

        #region Fill binary fields

        private void fillBits(bool fillMaskAndIp)
        {
            labelNetworkBits.Text = toBits(labelNetwork.Text);
            labelMinHostBits.Text = toBits(labelMinHost.Text);
            labelMaxHostBits.Text = toBits(labelMaxHost.Text);
            labelBroadcastBits.Text = toBits(labelBroadcast.Text);
            if (fillMaskAndIp)
            {
                labelIPBits.Text = toBits(netAddress);
                labelMaskBits.Text = toBits(mask);
            }
        }

        private string toBits(string text)
        {
            string[] arr = text.Split('.');
            string bits = "";
            int temp;
            string tempStr = "";
            foreach (string n in arr)
            {
                temp = Convert.ToInt32(n);
                tempStr = Convert.ToString(temp, 2);
                while (tempStr.Length < 8)
                    tempStr = "0" + tempStr;
                tempStr = tempStr.Substring(0, 4) + " " + tempStr.Substring(4, tempStr.Length - 4);
                bits += tempStr + ".";
            }
            return bits.Substring(0, bits.Length - 1);
        }

        #endregion

        #region Subnetting

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            richTextBoxSubnets.Text = "Number of subnets: " + numericUpDownSubnets.Value.ToString() + "\n";
            richTextBoxSubnets.Text += "Bits in mask for subnets: " + culcBitsForSubnet().ToString() + "\n";
            richTextBoxSubnets.Text += "Hosts in each subnet: " + culcHostsForSubnets().ToString() + "\n";
            richTextBoxSubnets.Text += "-------------------------------------------\n";
            richTextBoxSubnets.Text += "Mask structure (n - net, s - subnet, h - host):\n";
            richTextBoxSubnets.Text += buildMaskStructure() + "\n";
            richTextBoxSubnets.Text += "-------------------------------------------\n\n";
            for(int i = 0; i < numericUpDownSubnets.Value; i++)
            {
                richTextBoxSubnets.Text += "----- Subnet " + (i + 1) + " -----\n";
                richTextBoxSubnets.Text += "Subnet adress: " + culcAddressForSubnet(i) + "\n";
                richTextBoxSubnets.Text += "Mask: " + culcMaskForSubnet(i) + "\n";
                richTextBoxSubnets.Text += "\n";
            }
        }

        private string culcMaskForSubnet(int num)
        {
            string binM = labelMaskBits.Text.Replace(" ", String.Empty).Replace(".", String.Empty);
            int subnetCount = culcBitsForSubnet();
            int netCount = 0;
            foreach (char ch in binM)
            {
                if (ch == '1')
                    netCount++;
            }
            string newBinM = "";
            string[] arr = new string[4];
            int count = 0;
            int index = 0;
            while (newBinM.Length < binM.Length+1)
            {
                if(count == 8)
                {
                    arr[index] = Convert.ToInt32(newBinM.Substring(count * index, count), 2).ToString();
                    count = 0;
                    index++;
                }
                if (newBinM.Length < netCount + subnetCount)
                    newBinM += "1";
                else
                    newBinM += "0";
                count++;
            }
            return arr[0] + "." + arr[1] + "." + arr[2] + "." + arr[3];
        }

        private string culcAddressForSubnet(int num)
        {
            string binN = labelNetworkBits.Text.Replace(" ", String.Empty).Replace(".", String.Empty);
            long network = Convert.ToInt64(binN, 2);
            network += (int)Math.Pow(2, Convert.ToString((culcHostsForSubnets() + 1), 2).Length) * num;
            string newBinN = Convert.ToString(network, 2);
            while (newBinN.Length < binN.Length)
                newBinN = "0" + newBinN;
            string[] arr = new string[4];
            for (int i = 0; i < 4; i++)
                arr[i] = Convert.ToInt32(newBinN.Substring(i * 8, 8), 2).ToString();
            return arr[0] + "." + arr[1] + "." + arr[2] + "." + arr[3]; ;
        }

        private int culcHostsForSubnets()
        {
            string binM = labelMaskBits.Text.Replace(" ", String.Empty).Replace(".", String.Empty);
            int netCount = 0,
                subNetCount = culcBitsForSubnet(),
                hostCount = 0;
            foreach (char ch in binM)
            {
                if (ch == '1')
                    netCount++;
            }
            hostCount = binM.Length - subNetCount - netCount;
            string bin = "";
            for (int i = 0; i < hostCount; i++)
            {
                bin += "1";
            }
            return Convert.ToInt32(bin, 2) - 1;
        }

        private string buildMaskStructure()
        {
            string res = "";
            string binM = labelMaskBits.Text.Replace(" ", String.Empty).Replace(".", String.Empty);
            int netCount = 0, 
                subNetCount = culcBitsForSubnet(), 
                hostCount = 0;
            foreach (char ch in binM)
            {
                if (ch == '1')
                    netCount++;
            }
            hostCount = binM.Length - subNetCount - netCount;
            for (int i = 0; i < netCount; i++)
                res += "n";
            res += " ";
            for (int i = 0; i < subNetCount; i++)
                res += "s";
            res += " ";
            for (int i = 0; i < hostCount; i++)
                res += "h";
            return res + "  / " + (netCount + subNetCount);
        }

        private int culcBitsForSubnet()
        {
            string binNum = "1";
            int subnets = (int)numericUpDownSubnets.Value;
            int temp;
            while(true)
            {
                temp = Convert.ToInt32(binNum, 2) + 1;
                if (temp >= subnets)
                    break;
                binNum += "1";
            }
            return binNum.Length;
        }

        #endregion
    }
}
