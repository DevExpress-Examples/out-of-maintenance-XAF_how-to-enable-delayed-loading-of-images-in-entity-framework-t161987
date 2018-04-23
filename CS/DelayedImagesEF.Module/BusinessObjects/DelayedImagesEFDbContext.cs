using System;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.EF.Utils;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp;

namespace  DelayedImagesEF.Module.BusinessObjects {
	public class DelayedImagesEFDbContext : DbContext {
		public DelayedImagesEFDbContext(String connectionString)
			: base(connectionString) {
		}
		public DelayedImagesEFDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
        public DbSet<SampleObject> SampleObjects { get; set; }
        public DbSet<DelayedImage> DelayedImages { get; set; }
	}
    [DefaultClassOptions]
    public class SampleObject : IXafEntityObject {
        [Browsable(false)]
        public int Id { get; protected set; }
        public string Name { get; set; }
        [Delayed, ExpandObjectMembers(ExpandObjectMembers.Always)]
        public virtual DelayedImage Image { get; set; }
        public void OnCreated() {
            Image = new DelayedImage();
        }
        public void OnLoaded() { }
        public void OnSaving() { }
    }
    public class DelayedImage {
        [Browsable(false)]
        public int Id { get; protected set; }
        [ImageEditor, Delayed, VisibleInListView(true), XafDisplayName("Image")]
        public byte[] ImageData { get; set; }
    }

}