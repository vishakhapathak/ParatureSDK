using System;
using System.Collections;
using System.Threading;
using System.Xml;
using ParatureSDK.ApiHandler.ApiMethods;
using ParatureSDK.EntityQuery;
using ParatureSDK.ModuleQuery;
using ParatureSDK.ParaObjects;
using ParatureSDK.XmlToObjectParser;

namespace ParatureSDK.ApiHandler
{
    /// <summary>
    /// Contains all the methods that allow you to interact with the Parature Knowledge Base module.
    /// </summary>
    public class Article : FirstLevelApiMethods<ParaObjects.Article, ArticleQuery>
    {
        private static ParaEnums.ParatureModule _module = ParaEnums.ParatureModule.Article;

        /// <summary>
        /// Contains all the methods needed to work with the download module's folders.
        /// </summary>
        public class ArticleFolder : FolderApiMethods<ParaObjects.ArticleFolder, ArticleFolderQuery> {}
    }
}