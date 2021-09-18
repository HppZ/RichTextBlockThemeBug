using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

            if (_richTextBlock == null)
            {
                _richTextBlock = GetTemplateChild("RichTextBlock") as RichTextBlock;
            }

            var _curBlock = new Paragraph();
            _richTextBlock.Blocks.Add(_curBlock);

            var inline = new Hyperlink()
            {
                UnderlineStyle = UnderlineStyle.None
            };
            inline.Inlines.Add(new Run() { Text = "@one" });

            _curBlock.Inlines.Add(inline);

            base.OnApplyTemplate();
        }
    }
}
