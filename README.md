# Outlook邮箱帐号快捷配置工具 - OlConfigTools


## 工具开发由头

公司IT维护人员经常有帮用户配置Outlook 邮箱帐号密码的需求，设置虽然也不复杂，但需要记住邮箱对应的pop和smtp服务器，也是件麻烦事。
尤其有多个不同服务器下邮箱，甚至多套不同配置情况更是。因此产生了开发一个解决此问题工具的需求。
>> 部分思路代码来自：https://blog.csdn.net/qq_21703215/article/details/78922328 鸣谢 半块菠萝 ；）

## 工具实现原理

* 通过程序生成模板对的prf文件
* 调用Oulook /improtprf 导入配置
* 完事，自己设置帐号对应的密码，应该是出于安全考虑prf导入不支持密码




### 使用说明
 
 ![](https://github.com/LeoXionggg/OlConfigTools/blob/master/man.jpg) 

#### 配置文件 Settings.xml 

* Company 对应多套不同的配置
    * Name 配置名称，不应有重复
    * Account 帐号信息每套配置下可多个
        * AccountSufix 邮箱帐号后缀
        * POP3Server 邮箱pop3服务地址
        * SMTPServer 邮箱smtp服务地址
        * DefaultAccount 是否默认号帐，取值：TRUE/FALSE

#### 以下是个例子
```xml
<?xml version="1.0" encoding="utf-8" ?>
<PrfSetInfos>
  <Company Name="My">
    <Account AccountSufix="163.com"
             POP3Server="pop.163.com"
             SMTPServer="smtp.163.com"
             DefaultAccount="TRUE" />
    <Account AccountSufix="qq.net"
             POP3Server="pop.qq.com"
             SMTPServer="smtp.qq.com"
             DefaultAccount="" />
  </Company>
  <Company Name="SHE">
    <Account AccountSufix="126.com"
             POP3Server="pop.126.com"
             SMTPServer="smtp.126.com"
             DefaultAccount="TRUE" /> 
  </Company>     
</PrfSetInfos>
```


### 模板文件Templ.prf 

其为文本格式，可以根据要求进行更多的修改。prf文件详细说明请见微软官方文档 
[使用 Outlook 配置文件 (PRF) 文件自定义 Outlook 配置文件](https://docs.microsoft.com/zh-cn/previous-versions/office/office-2010/cc179062(v=office.14)?redirectedfrom=MSDN#BKMK_Overview)


## 工具适用性

### 以下系统级outlook 版本测试运行通过
* Win7 32bit
 * Outlook 2010
* Win10 64bit
 * Outlook 2019


## 开发语言

`C# `.Net Framework



## 项目文件

```
.
│  .gitattributes
│  .gitignore
│  App.config
│  fmMain.cs
│  fmMain.Designer.cs
│  fmMain.resx
│  GetOutlookPath.cs
│  OlConfigTools.csproj
│  OlConfigTools.csproj.user
│  OlConfigTools.ico
│  OlConfigTools.sln
│  OlPrfSetHelper.cs
│  OlPrfSetInfo.cs
│  Program.cs
│  README.md
│  Settings.xml             //帐号配置文件
│  templ.prf                //outlook prf导入配置模板
│
└─Properties
        AssemblyInfo.cs
        Resources.Designer.cs
        Resources.resx
        Settings.Designer.cs
        Settings.settings

.
```
