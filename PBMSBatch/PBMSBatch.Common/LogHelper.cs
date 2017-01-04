using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PBMSBatch.Common
{
    public partial class LogHelper
    {
        private static object _locker = new object();//锁对象

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="message">消息</param>
        public static void Write(string message)
        {
            lock (_locker)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    if (!Directory.Exists(IOHelper.GetMapPath("/Log/txtlogs/")))
                    {
                        Directory.CreateDirectory(IOHelper.GetMapPath("/Log/txtlogs/"));
                    }

                    string fileName = IOHelper.GetMapPath("/Log/txtlogs/") + DateTime.Now.ToString("yyyyMMdd") + ".log";
                    FileInfo fileInfo = new FileInfo(fileName);
                    if (!fileInfo.Directory.Exists)
                    {
                        fileInfo.Directory.Create();
                    }

                    fs = fileInfo.OpenWrite();
                    sw = new StreamWriter(fs);
                    sw.BaseStream.Seek(0, SeekOrigin.End);
                    sw.Write("Log Entry : ");
                    sw.Write("{0}", DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss"));
                    sw.Write(Environment.NewLine);
                    sw.Write(message);
                    sw.Write(Environment.NewLine);
                    sw.Write("------------------------------------");
                    sw.Write(Environment.NewLine);
                }
                catch (Exception ex)
                {
                    //throw ex;
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Flush();
                        sw.Close();
                    }
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }
        }

        public static void WriteRequestTranDataLog(string message)
        {
            lock (_locker)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    if (!Directory.Exists(IOHelper.GetMapPath("/Log/trandatalogs/")))
                    {
                        Directory.CreateDirectory(IOHelper.GetMapPath("/Log/trandatalogs/"));
                    }
                    string fileName = IOHelper.GetMapPath("/Log/trandatalogs/") + DateTime.Now.ToString("yyyyMMdd") + ".log";

                    FileInfo fileInfo = new FileInfo(fileName);
                    if (!fileInfo.Directory.Exists)
                    {
                        fileInfo.Directory.Create();
                    }

                    fs = fileInfo.OpenWrite();
                    sw = new StreamWriter(fs);
                    sw.BaseStream.Seek(0, SeekOrigin.End);
                    sw.Write("Log Entry : ");
                    sw.Write("{0}", DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss"));
                    sw.Write(Environment.NewLine);
                    sw.Write(message);
                    sw.Write(Environment.NewLine);
                    sw.Write("------------------------------------");
                    sw.Write(Environment.NewLine);
                }
                catch (Exception ex)
                {
                    //throw ex;
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Flush();
                        sw.Close();
                    }
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }

        }

        public static void WriteRequestSendSMSLog(string message)
        {
            lock (_locker)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    if (!Directory.Exists(IOHelper.GetMapPath("/Log/sendsmslogs/")))
                    {
                        Directory.CreateDirectory(IOHelper.GetMapPath("/Log/sendsmslogs/"));
                    }

                    string fileName = IOHelper.GetMapPath("/Log/sendsmslogs/") + DateTime.Now.ToString("yyyyMMdd") + ".log";

                    FileInfo fileInfo = new FileInfo(fileName);
                    if (!fileInfo.Directory.Exists)
                    {
                        fileInfo.Directory.Create();
                    }

                    fs = fileInfo.OpenWrite();
                    sw = new StreamWriter(fs);
                    sw.BaseStream.Seek(0, SeekOrigin.End);
                    sw.Write("Log Entry : ");
                    sw.Write("{0}", DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss"));
                    sw.Write(Environment.NewLine);
                    sw.Write(message);
                    sw.Write(Environment.NewLine);
                    sw.Write("------------------------------------");
                    sw.Write(Environment.NewLine);
                }
                catch (Exception ex)
                {
                    //throw ex;
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Flush();
                        sw.Close();
                    }
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }

        }

        public static void WritePostData2CustomerLog(string message)
        {
            lock (_locker)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    if (!Directory.Exists(IOHelper.GetMapPath("/Log/postdatalogs/")))
                    {
                        Directory.CreateDirectory(IOHelper.GetMapPath("/Log/postdatalogs/"));
                    }

                    string fileName = IOHelper.GetMapPath("/Log/postdatalogs/") + DateTime.Now.ToString("yyyyMMdd") + ".log";

                    FileInfo fileInfo = new FileInfo(fileName);
                    if (!fileInfo.Directory.Exists)
                    {
                        fileInfo.Directory.Create();
                    }

                    fs = fileInfo.OpenWrite();
                    sw = new StreamWriter(fs);
                    sw.BaseStream.Seek(0, SeekOrigin.End);
                    sw.Write("Log Entry : ");
                    sw.Write("{0}", DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss"));
                    sw.Write(Environment.NewLine);
                    sw.Write(message);
                    sw.Write("------------------------------------");
                    sw.Write(Environment.NewLine);
                }
                catch (Exception ex)
                {
                    //throw ex;
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Flush();
                        sw.Close();
                    }
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }

        }

        public static void Write(Exception ex)
        {
            string message = string.Format("消息类型：{0}\r\n消息内容：{1}\r\n引发异常的方法：{2}\r\n引发异常源：{3}"
                , ex.GetType().Name
                , ex.Message
                 , ex.TargetSite
                 , ex.Source + ex.StackTrace
                 );
            Write(message);
        }
    }
}
