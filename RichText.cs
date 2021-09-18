using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace App6
{
    public sealed class RichText : Control
    {
        public RichText()
        {
            this.DefaultStyleKey = typeof(RichText);
        }

        private RichTextBlock _richTextBlock;

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (_richTextBlock == null)
            {
                _richTextBlock = GetTemplateChild("RichTextBlock_Part") as RichTextBlock;
            }
            var hyperlink = new Hyperlink()
            {
                UnderlineStyle = UnderlineStyle.None,
            };
            hyperlink.Inlines.Add(new Run() { Text = "one" });

            var paragraph = new Paragraph();
            paragraph.Inlines.Add(hyperlink);


            _richTextBlock.Blocks.Add(paragraph);
        }
    }
}
