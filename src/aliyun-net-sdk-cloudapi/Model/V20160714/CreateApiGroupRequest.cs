/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CloudAPI.Transform.V20160714;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class CreateApiGroupRequest : RpcAcsRequest<CreateApiGroupResponse>
    {
        public CreateApiGroupRequest()
            : base("CloudAPI", "2016-07-14", "CreateApiGroup")
        {
        }

		private string _groupName;

		private string _description;

		public string GroupName
		{
			get
			{
				return _groupName;
			}
			set	
			{
				_groupName = value;
				DictionaryUtil.Add(QueryParameters, "GroupName", value);
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set	
			{
				_description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

        public override CreateApiGroupResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateApiGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}