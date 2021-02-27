using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Common
{


    public class XmlHeper
    {
        #region 将XML转为DateSet
        /// <summary>
        /// 将xml对象内容字符串转换为DataSet
        /// </summary>
        /// <param name="xmlData">XML字符串</param>
        /// <returns>DateSet</returns>
        public static DataSet ConvertXMLToDataSet(string xmlData)
        {
            StringReader stream = null;
            XmlTextReader reader = null;
            try
            {
                DataSet xmlDS = new DataSet();
                stream = new StringReader(xmlData);
                //从stream装载到XmlTextReader
                reader = new XmlTextReader(stream);
                xmlDS.ReadXml(reader);
                return xmlDS;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (reader != null) reader.Close();
            }
        }

        /// <summary>
        /// 将xml文件转换为DataSet
        /// </summary>
        /// <param name="xmlFile">XML文件路径</param>
        /// <returns>DateSet</returns>
        public static DataSet ConvertXMLFileToDataSet(string xmlFile)
        {
            StringReader stream = null;
            XmlTextReader reader = null;
            try
            {
                XmlDocument xmld = new XmlDocument();
                xmld.Load(xmlFile);

                DataSet xmlDS = new DataSet();
                stream = new StringReader(xmld.InnerXml);
                //从stream装载到XmlTextReader
                reader = new XmlTextReader(stream);
                xmlDS.ReadXml(reader);
                //xmlDS.ReadXml(xmlFile);
                return xmlDS;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (reader != null) reader.Close();
            }
        }
        #endregion

        #region DateSet转XML
        /// <summary>
        /// DateSet转XML字符串
        /// </summary>
        /// <param name="ds">DateSet</param>
        /// <returns>XML字符串</returns>
        public static string ConvertDataSetToXML(DataSet ds)
        {
            MemoryStream stream = null;
            XmlTextWriter writer = null;
            ds.DataSetName = "ds";
            try
            {
                stream = new MemoryStream();
                //从stream装载到XmlTextReader
                writer = new XmlTextWriter(stream, Encoding.Unicode);

                //用WriteXml方法写入文件.
                ds.WriteXml(writer);
                int count = (int)stream.Length;
                byte[] arr = new byte[count];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(arr, 0, count);

                UnicodeEncoding utf = new UnicodeEncoding();
                return utf.GetString(arr).Trim().Replace("﻿<ds", "<ds");
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (writer != null) writer.Close();
            }
        }

        /// <summary>
        /// DataSet转换为xml文件
        /// </summary>
        /// <param name="ds">DateSet</param>
        /// <param name="xmlFile">XML保存完整路径</param>
        public static void ConvertDataSetToXMLFile(DataSet ds, string xmlFile)
        {
            MemoryStream stream = null;
            XmlTextWriter writer = null;
            ds.DataSetName = "ds";
            try
            {
                stream = new MemoryStream();
                //从stream装载到XmlTextReader
                writer = new XmlTextWriter(stream, Encoding.Unicode);

                //用WriteXml方法写入文件.
                ds.WriteXml(writer);
                int count = (int)stream.Length;
                byte[] arr = new byte[count];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(arr, 0, count);

                //返回Unicode编码的文本
                UnicodeEncoding utf = new UnicodeEncoding();
                StreamWriter sw = new StreamWriter(xmlFile);
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sw.WriteLine(utf.GetString(arr).Trim().Replace("﻿<ds", "<ds"));
                sw.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (writer != null) writer.Close();
            }
        }
        #endregion

        #region 将实体对象保存为XML本地文件
        /// <summary>
        /// 将实体对象保存为XML本地文件
        /// </summary>
        /// <typeparam name="T">实体对象</typeparam>
        /// <param name="obj">实体对象</param>
        /// <param name="path">XML保存路径</param>
        public static void SaveConfigInfo<T>(T obj, string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));

            if (obj == null)
            {
                throw new Exception("config object is null");

            }

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            using (TextWriter tr = new StreamWriter(fs))
            {
                xs.Serialize(tr, obj);
            }
        }
        #endregion

        #region 将本地XML文件转换为实体对象
        /// <summary>
        /// 将本地XML文件转换为实体对象 Class1 cl = LoadConfigInfo<Class1>(typeof(Class1), @"c:\1.xml");
        /// </summary>
        /// <typeparam name="T">实体对象</typeparam>
        /// <param name="type">实体对象类型 typeof(Class1)</param>
        /// <param name="path">XML本地路径</param>
        /// <returns>实体对象</returns>
        public static T LoadConfigInfo<T>(Type type, string path) where T : class, new()
        {
            XmlSerializer xs = new XmlSerializer(type);
            T appInfo = null;

            if (File.Exists(path))
            {
                try
                {
                    using (TextReader tr = new StreamReader(path))
                    {
                        appInfo = xs.Deserialize(tr) as T;
                    }
                }
                catch (Exception ex)
                {
                    File.Delete(path);
                }
            }
            return appInfo;
        }
        #endregion
    }

}
