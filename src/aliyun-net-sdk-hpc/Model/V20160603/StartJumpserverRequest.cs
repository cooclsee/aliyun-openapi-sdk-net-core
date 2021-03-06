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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.HPC.Transform.V20160603;

namespace Aliyun.Acs.HPC.Model.V20160603
{
    public class StartJumpserverRequest : RpcAcsRequest<StartJumpserverResponse>
    {
        public StartJumpserverRequest()
            : base("HPC", "2016-06-03", "StartJumpserver")
        {
			Method = MethodType.POST;
        }

		private string _tOken;

		private string _instanceId;

		private int? _force;

		public string Token
		{
			get
			{
				return _tOken;
			}
			set	
			{
				_tOken = value;
				DictionaryUtil.Add(QueryParameters, "TOKEN", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return _instanceId;
			}
			set	
			{
				_instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public int? Force
		{
			get
			{
				return _force;
			}
			set	
			{
				_force = value;
				DictionaryUtil.Add(QueryParameters, "Force", value.ToString());
			}
		}

        public override StartJumpserverResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return StartJumpserverResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}