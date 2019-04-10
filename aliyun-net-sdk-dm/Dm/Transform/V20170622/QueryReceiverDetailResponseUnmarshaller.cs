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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class QueryReceiverDetailResponseUnmarshaller
    {
        public static QueryReceiverDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QueryReceiverDetailResponse queryReceiverDetailResponse = new QueryReceiverDetailResponse();

			queryReceiverDetailResponse.HttpResponse = context.HttpResponse;
			queryReceiverDetailResponse.RequestId = context.StringValue("QueryReceiverDetail.RequestId");
			queryReceiverDetailResponse.TotalCount = context.IntegerValue("QueryReceiverDetail.TotalCount");
			queryReceiverDetailResponse.NextStart = context.StringValue("QueryReceiverDetail.NextStart");
			queryReceiverDetailResponse.DataSchema = context.StringValue("QueryReceiverDetail.DataSchema");

			List<QueryReceiverDetailResponse.QueryReceiverDetail_Detail> queryReceiverDetailResponse_data = new List<QueryReceiverDetailResponse.QueryReceiverDetail_Detail>();
			for (int i = 0; i < context.Length("QueryReceiverDetail.Data.Length"); i++) {
				QueryReceiverDetailResponse.QueryReceiverDetail_Detail detail = new QueryReceiverDetailResponse.QueryReceiverDetail_Detail();
				detail.Email = context.StringValue("QueryReceiverDetail.Data["+ i +"].Email");
				detail.Data = context.StringValue("QueryReceiverDetail.Data["+ i +"].Data");
				detail.CreateTime = context.StringValue("QueryReceiverDetail.Data["+ i +"].CreateTime");
				detail.UtcCreateTime = context.LongValue("QueryReceiverDetail.Data["+ i +"].UtcCreateTime");

				queryReceiverDetailResponse_data.Add(detail);
			}
			queryReceiverDetailResponse.Data = queryReceiverDetailResponse_data;
        
			return queryReceiverDetailResponse;
        }
    }
}