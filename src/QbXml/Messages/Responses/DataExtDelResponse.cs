﻿using QbSync.QbXml.Objects;
using System.Linq;
using System.Xml;

namespace QbSync.QbXml.Messages.Responses
{
    public class DataExtDelResponse : QbXmlResponseWithErrorRecovery<DataExtDelRet>
    {
        public DataExtDelResponse()
            : base("DataExtDelRs")
        {
        }

        protected override void ProcessResponse(XmlNode responseNode, QbXmlMsgResponse<DataExtDelRet> qbXmlResponse)
        {
            base.ProcessResponse(responseNode, qbXmlResponse);

            var dataExtRet = responseNode.SelectSingleNode("//DataExtDelRet");
            if (dataExtRet != null)
            {
                qbXmlResponse.Object = WalkType(typeof(DataExtDelRet), dataExtRet) as DataExtDelRet;
            }
        }
    }
}