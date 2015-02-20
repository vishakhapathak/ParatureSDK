﻿using System;
using ParatureSDK.ParaObjects;
using ParatureSDK.XmlToObjectParser;

namespace ParatureSDK
{
    /// <summary>
    /// Main Thread controller class
    /// </summary>
    public class ThreadPool
    {
        /// <summary>
        /// Main Thread object, limit of 5 parallel threads
        /// </summary>
        public class ObjectList
        {
            private static System.Threading.Semaphore sem = new System.Threading.Semaphore(5, 5);
            private ParaCredentials _paracredentials = null;
            private ParaEnums.ParatureModule _module;
            private System.Collections.ArrayList _Arguments = null;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="paracredentials"></param>
            /// <param name="module"></param>
            /// <param name="arguments"></param>
            public ObjectList(ParaCredentials paracredentials, ParaEnums.ParatureModule module, System.Collections.ArrayList arguments)
            {
                sem.WaitOne();
                _paracredentials = paracredentials;
                _module = module;
                _Arguments = new System.Collections.ArrayList(arguments);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="customerList"></param>
            public void Go(ParaEntityList<ParaObjects.Customer> customerList)
            {
                var ar = ApiCallFactory.ObjectGetList(_paracredentials, _module, _Arguments);
                var objectlist = ParaEntityParser.FillList<ParaObjects.Customer>(ar.xmlReceived);
                customerList.Data.AddRange(objectlist.Data);
                customerList.ApiCallResponse = ar;
                sem.Release();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="chatList"></param>
            /// <param name="includeTranscripts"></param>
            public void Go(ParaEntityList<ParaObjects.Chat> chatList, Boolean includeTranscripts)
            {
                var ar = ApiCallFactory.ObjectGetList(_paracredentials, _module, _Arguments);
                var objectlist = ParaEntityParser.FillList<ParaObjects.Chat>(ar.xmlReceived);
                chatList.Data.AddRange(objectlist.Data);
                chatList.ApiCallResponse = ar;
                sem.Release();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="accountList"></param>
            public void Go(ParaEntityList<ParaObjects.Account> accountList)
            {
                var ar = ApiCallFactory.ObjectGetList(_paracredentials, _module, _Arguments);
                var objectlist = ParaEntityParser.FillList<ParaObjects.Account>(ar.xmlReceived);
                accountList.Data.AddRange(objectlist.Data);
                accountList.ApiCallResponse = ar;
                sem.Release();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="accountList"></param>
            public void Go(ParaEntityList<ParaObjects.Ticket> ticketList)
            {
                var ar = ApiCallFactory.ObjectGetList(_paracredentials, _module, _Arguments);
                var objectlist = ParaEntityParser.FillList<ParaObjects.Ticket>(ar.xmlReceived);
                ticketList.Data.AddRange(objectlist.Data);
                ticketList.ApiCallResponse = ar;
                sem.Release();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="accountList"></param>
            public void Go(ParaEntityList<ParaObjects.Product> productList)
            {
                var ar = ApiCallFactory.ObjectGetList(_paracredentials, _module, _Arguments);
                var objectlist = ParaEntityParser.FillList<ParaObjects.Product>(ar.xmlReceived);
                productList.Data.AddRange(objectlist.Data);
                productList.ApiCallResponse = ar;
                sem.Release();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="accountList"></param>
            public void Go(ParaEntityList<ParaObjects.Asset> assetList)
            {
                var ar = ApiCallFactory.ObjectGetList(_paracredentials, _module, _Arguments);
                var objectlist = ParaEntityParser.FillList<ParaObjects.Asset>(ar.xmlReceived);
                assetList.Data.AddRange(objectlist.Data);
                assetList.ApiCallResponse = ar;
                sem.Release();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="accountList"></param>
            public void Go(ParaEntityList<ParaObjects.Download> downloadList)
            {
                var ar = ApiCallFactory.ObjectGetList(_paracredentials, _module, _Arguments);
                var objectlist = ParaEntityParser.FillList<ParaObjects.Download>(ar.xmlReceived);
                downloadList.Data.AddRange(objectlist.Data);
                downloadList.ApiCallResponse = ar;
                sem.Release();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="accountList"></param>
            public void Go(ParaEntityList<ParaObjects.Article> articleList)
            {
                var ar = ApiCallFactory.ObjectGetList(_paracredentials, _module, _Arguments);
                var objectlist = ParaEntityParser.FillList<ParaObjects.Article>(ar.xmlReceived);
                articleList.Data.AddRange(objectlist.Data);
                articleList.ApiCallResponse = ar;
                sem.Release();
            }
        }
    }
}