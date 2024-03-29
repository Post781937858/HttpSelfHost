﻿using HttpSelfHost.model;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace HttpSelfHost.WebApi.controllers
{
    public class DemoController:ApiController
    {


        [HttpGet]
        [HttpPost]
        public dynamic allStudents()
        {
            return new
            {
                result = true,
                desc =  "请求成功",
                data = new List<StudentInfo>()
                {
                    new StudentInfo
                    {
                        ClassId="ClassID982712311231",
                        Sex="男",
                        StudentId=Guid.NewGuid().ToString(),
                        StudentName="男学生一枚",
                        StudentNumber="XH2018090001"
                    },
                    new StudentInfo
                    {
                        ClassId="ClassID982712311232",
                        Sex="女",
                        StudentId=Guid.NewGuid().ToString(),
                        StudentName="女学生一枚",
                        StudentNumber="XH2018090002"
                    }
                }
            };
        }
        [HttpGet]
        [HttpPost]
        public dynamic queryStudents([FromBody]string name)
        {
            return new
            {
                result = true,
                desc = "查询请求成功,参数name:"+name,
                data = new List<StudentInfo>()
                {
                    new StudentInfo
                    {
                        ClassId="ClassID982712311231",
                        Sex="男",
                        StudentId=Guid.NewGuid().ToString(),
                        StudentName="男学生一枚",
                        StudentNumber="XH2018090001"
                    },
                    new StudentInfo
                    {
                        ClassId="ClassID982712311232",
                        Sex="女",
                        StudentId=Guid.NewGuid().ToString(),
                        StudentName="女学生一枚",
                        StudentNumber="XH2018090002"
                    }
                },
                page=1,
                total=2,
                pageCount=1
            };
        }
        [HttpGet]
        [HttpPost]
        public dynamic saveStudents([FromBody]StudentInfo info)
        {
            info.StudentId = Guid.NewGuid().ToString();
            return new
            {
                result = true,
                desc = "保存成功,学生姓名:" + info.StudentName,
                data = info.StudentId
            };
        }
    }
}
