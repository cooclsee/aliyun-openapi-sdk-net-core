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
using Aliyun.Acs.Push.Transform.V20150827;

namespace Aliyun.Acs.Push.Model.V20150827
{
    public class GenerateIotDevicesRequest : RpcAcsRequest<GenerateIotDevicesResponse>
    {
        public GenerateIotDevicesRequest()
            : base("Push", "2015-08-27", "GenerateIotDevices")
        {
        }

		private bool? _isDev;

		private long? _number;

		public bool? IsDev
		{
			get
			{
				return _isDev;
			}
			set	
			{
				_isDev = value;
				DictionaryUtil.Add(QueryParameters, "isDev", value.ToString());
			}
		}

		public long? Number
		{
			get
			{
				return _number;
			}
			set	
			{
				_number = value;
				DictionaryUtil.Add(QueryParameters, "Number", value.ToString());
			}
		}

        public override GenerateIotDevicesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return GenerateIotDevicesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}