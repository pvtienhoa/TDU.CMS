using TDU.CMS.ViewModels;

namespace TDU.CMS
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            InitBindings();
            ribbonControl1.Merge += ribbonControl1_Merge;
        }

        private void InitBindings()
        {
            var fluentAPI = mvvmContext1.OfType<CMSDbContextViewModel>();
            fluentAPI.BindCommand(importButton, (x, m) => x.Show(m), x => x.Modules[0]);
        }


        private void ribbonControl1_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            ribbonControl1.SelectedPage = e.MergedChild.SelectedPage;
        }}
}