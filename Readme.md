<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128589918/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T161987)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[DelayedImagesEFDbContext.cs](./CS/DelayedImagesEF.Module/BusinessObjects/DelayedImagesEFDbContext.cs) (VB: [DelayedImagesEFDbContext.vb](./VB/DelayedImagesEF.Module/BusinessObjects/DelayedImagesEFDbContext.vb))**
<!-- default file list end -->
# OBSOLETE - How to enable delayed loading of images in Entity Framework 6


<p>When a EF6 application displays a lot of large images in a List View, it may consume a lot of memory. It is most actual for ASP.NET applications with many simultaneously connected clients. This example describes how to enable delayed (or <em>lazy</em>) loading of images to reduce the memory usage.<br /><br /><strong>Entity Framework</strong> supports <em>lazy loading </em>for referenced entities, not for simple properties. Thus, you need to declare a new <strong>DelayedImage</strong> entity exposing the ImageData property of a byte array type for storing images. Then, you can declare a reference property of the <strong>DelayedImage </strong>type where required (in this example, such a property is declared in the <strong>SampleObject </strong>class). </p>
<p>It is necessary to set the <a href="http://help.devexpress.com/#Xaf/clsDevExpressExpressAppEFUtilsDelayedAttributetopic">DevExpress.ExpressApp.EF.Utils.Delayed</a><strong> </strong>attribute both to the reference property and the image storage property. Also you need to apply the <a href="http://help.devexpress.com/#Xaf/DevExpressPersistentBaseExpandObjectMembersEnumtopic">ExpandObjectMembers</a><strong> </strong>attribute to the reference property to make the image visible.</p>
<p><br /><br /><strong>See Also: </strong><a href="https://www.devexpress.com/Support/Center/p/T162404">How to enable delayed loading of images in XPO</a></p>

<br/>


