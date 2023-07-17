#nullable enable

using System.Collections.Generic;

using Word=Microsoft.Office.Interop.Word;

namespace ExtractReferenceDocumentation
{
  internal class Chapter
  {
    public Chapter(Chapter? parent, int level, int number, Word.Paragraph heading)
    {
      Parent = parent;
      Level = level;
      Number = number;
      Heading = heading;
      HeadingText = heading?.Range.Text?.Trim();
    }

    public Chapter? Parent { get; private set; }

    public int Level { get; private set; }

    public int Number { get; private set; }

    public Word.Paragraph Heading { get; private set; }

    public string? HeadingText { get; private set; }

    public string? Namespace {get; set; }

    public List<Chapter> SubChapters { get; set;} = new List<Chapter>();
    public List<Word.Paragraph> Paragraphs { get; set;} = new();
    
    public List<Word.Table> Tables { get; set;} = new();

    public string NumberStr
    {
      get
      {
        var str = Parent?.NumberStr;
        if (str!=null)
          str+="."+Number.ToString();
        else
          str=Number.ToString();
        return str;
      }
    }

    public override string ToString()
    {
      return $"Chapter {NumberStr} {HeadingText}";
    }
  }
}
