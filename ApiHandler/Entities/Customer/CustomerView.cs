using System;
using System.Xml;
using ParatureSDK.EntityQuery;
using ParatureSDK.ParaObjects;
using ParatureSDK.XmlToObjectParser;

namespace ParatureSDK.ApiHandler.Entities.Customer
{
    public class CustomerView
    {
        private static ParaEnums.ParatureEntity _entityType = ParaEnums.ParatureEntity.view;
        private static ParaEnums.ParatureModule _moduleType = ParaEnums.ParatureModule.Customer;

        /// <summary>
        /// Returns a view object with all of its properties filled.
        /// </summary>
        /// <param name="id">
        /// The view number that you would like to get the details of.
        /// Value Type: <see cref="long" />   (System.Int64)
        ///</param>
        /// <param name="creds">
        /// The Parature Credentials class is used to hold the standard login information. It is very useful to have it instantiated only once, with the proper information, and then pass this class to the different methods that need it.
        /// </param>
        /// <returns></returns>
        public static ParaObjects.CustomerView GetDetails(Int64 id, ParaCredentials creds)
        {
            var entity = ApiUtils.FillDetails<ParaObjects.CustomerView>(id, creds, _entityType);
            return entity;
        }

        /// <summary>
        /// Returns an view object from a XML Document. No calls to the APIs are made when calling this method.
        /// </summary>
        /// <param name="xml">
        /// The view XML, is should follow the exact template of the XML returned by the Parature APIs.
        /// </param>
        public static ParaObjects.CustomerView GetDetails(XmlDocument xml)
        {
            var entity = ParaEntityParser.EntityFill<ParaObjects.CustomerView>(xml);

            return entity;
        }

        /// <summary>
        /// Returns an view list object from a XML Document. No calls to the APIs are made when calling this method.
        /// </summary>
        /// <param name="listXml">
        /// The view List XML, is should follow the exact template of the XML returned by the Parature APIs.
        /// </param>
        public static ParaEntityList<ParaObjects.CustomerView> GetList(XmlDocument listXml)
        {
            var list = ParaEntityParser.FillList<ParaObjects.CustomerView>(listXml);

            list.ApiCallResponse.XmlReceived = listXml;

            return list;
        }

        /// <summary>
        /// Get the List of views from within your Parature license
        /// </summary>
        /// <param name="creds"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public static ParaEntityList<ParaObjects.CustomerView> GetList(ParaCredentials creds, ViewQuery query, ParaEnums.ParatureModule module)
        {
            return ApiUtils.FillList<ParaObjects.CustomerView>(creds, query, _entityType, _moduleType);
        }

        public static ParaEntityList<ParaObjects.CustomerView> GetList(ParaCredentials creds, ParaEnums.ParatureModule module)
        {
            return ApiUtils.FillList<ParaObjects.CustomerView>(creds, new ViewQuery(), _entityType, _moduleType);
        }
    }
}