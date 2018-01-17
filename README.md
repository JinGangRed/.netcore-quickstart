# netcore-quickstart  
项目基于ASP.Net Core 2.0 WebApi 创建的快速启动项目   
可以直接下载使用，参照ValuesController、UserMember等的实现，用于快速搭建一个基础的ASP.Net Core 2.0项目。
## 项目框架介绍
1.  目录介绍
  * CMS_Core: 项目的基础核心文件主要定义一些枚举，所有其他类库均可以引用本库；
  * CMS_DAL: Data Access Layer 项目的数据库连接相关。如，定义数据模型，定义数据库上下文等
  * CMS_Services: 相当于BLL(Business Logic Layer)项目的业务逻辑层。
  * CMS_VModels: View Model，和业务相关的视图类型的模型
  * CMS_Web_API: API 层
2.  项目关系引用  
	CMS_Core  <------  CMS_DAL  <------  CMS_Services  <------  CMS_Web_API  
	CMS_Core  <------  CMS_VModels  <------  CMS_Services  
	CMS_Core  <------  CMS_Services  
	CMS_Core  <------  CMS_Web_API  
	CMS_VModels  <------  CMS_Web_API  
  
## 项目使用介绍
  可直接下载该快速启动项目,在此基础上按照使用介绍进行扩展
## 个人信息
     邮箱：15950590137@163.com  
     博客园：[畅想技术](http://www.cnblogs.com/kingkangstudy/)

