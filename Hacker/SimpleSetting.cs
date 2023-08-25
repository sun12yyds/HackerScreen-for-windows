using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker
{
    /// <summary>
    /// 用于保存设置的类，自定义的配置文件
    /// </summary>
    public class SimpleSetting
    {
        ///<summary>
        /// 是否使用本地文件
        /// </summary>
        public bool isLocal { get; set; }
        /// <summary>
        /// 网页地址或本地文件路径
        /// </summary>
        public string uInfo { get; set; }
        /// <summary>
        /// 透明度
        /// </summary>
        public int Opacity { get; set; }
        /// <summary>
        /// 是否自动退出
        /// </summary>
        public bool autoExit { get; set; }

        public SimpleSetting()
        {
            isLocal = true;
            uInfo = "";
            Opacity = 100;
            autoExit = true;
        }

        public SimpleSetting(bool isLocal, string uInfo, int opacity, bool autoExit)
        {
            this.isLocal = isLocal;
            this.uInfo = uInfo;
            Opacity = opacity;
            this.autoExit = autoExit;
        }

        /// <summary>
        /// 从文件中读取设置
        /// </summary>
        /// <param name="path">配置文件路径</param>
        public SimpleSetting(string path)
        {
            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(SimpleSetting));
            using (System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open))
            {
                SimpleSetting ss = (SimpleSetting)xs.Deserialize(fs);
                isLocal = ss.isLocal;
                uInfo = ss.uInfo;
                Opacity = ss.Opacity;
                autoExit = ss.autoExit;
            }
        }

        /// <summary>
        /// 保存设置到文件
        /// </summary>
        /// <param name="path">配置文件路径</param>
        public void Save(string path)
        {
            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(SimpleSetting));
            using (System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Create))
            {
                xs.Serialize(fs, this);
            }
        }
    }
}
