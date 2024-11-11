using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
    public class Paragraph : IDocumentComponent
    {
        private string _text;
        public Paragraph(string text)
        {
            _text = text;
        }
        public void Add(IDocumentComponent component)
        {
            throw new NotImplementedException();
        }
        public void Remove(IDocumentComponent component)
        {
            throw new NotImplementedException();
        }
        public void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + _text);
        }
    }
}
