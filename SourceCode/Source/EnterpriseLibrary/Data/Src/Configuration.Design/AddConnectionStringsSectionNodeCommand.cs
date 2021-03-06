﻿/*********************************************        
作者：曹旭升              
QQ：279060597
访问博客了解详细介绍及更多内容：   
http://blog.shengxunwei.com
**********************************************/
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
using System.Diagnostics;
namespace Microsoft.Practices.EnterpriseLibrary.Data.Configuration.Design
{
	sealed class AddConnectionStringsSectionNodeCommand : AddChildNodeCommand
	{
		public AddConnectionStringsSectionNodeCommand(IServiceProvider serviceProvider)
			: base(serviceProvider, typeof(ConnectionStringsSectionNode))
        {
        }
		protected override void OnExecuted(EventArgs e)
		{
			ConnectionStringsSectionNode node = ChildNode as ConnectionStringsSectionNode;
			Debug.Assert(null != node, "Expected ConnectionStringsSectionNode");
			new AddConnectionStringSettingsNodeCommand(ServiceProvider).Execute(node);
		}		
	}
}
