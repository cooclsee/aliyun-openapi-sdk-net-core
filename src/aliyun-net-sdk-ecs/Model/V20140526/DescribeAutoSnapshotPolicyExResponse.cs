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
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeAutoSnapshotPolicyExResponse : AcsResponse
	{
	    public int? TotalCount { get; set; }

	    public int? PageNumber { get; set; }

	    public int? PageSize { get; set; }

	    public List<AutoSnapshotPolicy> AutoSnapshotPolicies { get; set; }

	    public class AutoSnapshotPolicy{
	        public int? AutoSnapshotPolicyId { get; set; }

	        public string RegionId { get; set; }

	        public string AutoSnapshotPolicyName { get; set; }

	        public string TimePoints { get; set; }

	        public string RepeatWeekdays { get; set; }

	        public int? RetentionDays { get; set; }

	        public int? DiskNums { get; set; }

	        public string CreationTime { get; set; }
	    }
	}
}