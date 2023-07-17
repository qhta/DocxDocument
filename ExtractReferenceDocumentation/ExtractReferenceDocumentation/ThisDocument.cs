#nullable enable
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

using Microsoft.Office.Tools.Word;
using Microsoft.VisualStudio.Tools.Applications.Runtime;

using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

using ModelGenDataConfig;
//using Microsoft.Office.Interop.Word;

namespace ExtractReferenceDocumentation
{
  public partial class ThisDocument
  {

    private void ThisDocument_Startup(object sender, System.EventArgs e)
    {
      ModelConfig.Instance.LoadData();
      var chapters = GetChapters();
      ProcessChapters(chapters);
    }

    private List<Chapter> GetChapters()
    {
      var chapters = new List<Chapter>();
      try
      {
        Chapter? chapter = null;
        var priorLevel = 0;
        var endDoc = this.StoryRanges[Word.WdStoryType.wdMainTextStory].End;
        var para = this.Paragraphs.First;
        while (para != null)
        {
          var text = para.Range.Text.Trim();
          //if (text.StartsWith("document"))
          Debug.WriteLine(text);
          Word.Style style = para.get_Style();
          var styleName = style.NameLocal;
          if (styleName.StartsWith("Nagłówek "))
          {
            var level = int.Parse(styleName.Substring(styleName.Length - 1, 1));
            if (level == priorLevel)
            {
              chapter = NewChapter(chapters, chapter?.Parent, para, level);
            }
            else
            if (level > priorLevel)
            {
              chapter = NewChapter(chapters, chapter, para, level);
              priorLevel = level;
            }
            else
            {
              chapter = chapter?.Parent;
              while (chapter != null && chapter.Level >= level)
                chapter = chapter.Parent;
              chapter = NewChapter(chapters, chapter, para, level);
              priorLevel = level;
            }
          }
          else if (chapter != null)
          {
            Word.Table? aTable = null;
            foreach (var table in para.Range.Tables)
            {
              aTable = table as Word.Table;
              if (aTable != null)
              {
                chapter.Tables.Add(aTable);
                para = aTable.Range.Paragraphs.Last;
              }
            }
            if (aTable == null)
              chapter.Paragraphs.Add(para);
          }
          para = para.Next();
        }
      }
      catch (Exception e)
      {
      }
      return chapters;
    }

    private static Chapter NewChapter(List<Chapter> chapters, Chapter? chapter, Word.Paragraph para, int level)
    {
      if (chapter != null)
      {
        var newChapter = new Chapter(chapter, level, chapter.SubChapters.Count + 1, para);
        chapter.SubChapters.Add(newChapter);
        chapter = newChapter;
      }
      else
      {
        var newChapter = new Chapter(chapter, level, chapters.Count + 1, para);
        chapters.Add(newChapter);
        chapter = newChapter;
      }

      return chapter;
    }

    private void ProcessChapters(List<Chapter> chapters)
    {
      foreach (var chapter in chapters)
        ProcessChapter(chapter);
    }

    private void ProcessChapter(Chapter chapter)
    {
      var heading = chapter.Heading;
      var text = heading.Range.Text.Trim();
      if (ModelConfig.Instance.Headings2Namespaces.TryGetValue(text, out var ns))
      {
        heading.Range.HighlightColorIndex = Word.WdColorIndex.wdBrightGreen;
        chapter.Namespace = ns;
      }
      else
      {
        if (chapter.SubChapters.Count == 0)
        {
          heading.Range.HighlightColorIndex = Word.WdColorIndex.wdYellow;
          foreach (var para in chapter.Paragraphs)
            para.Range.HighlightColorIndex = Word.WdColorIndex.wdPink;
          foreach (var table in chapter.Tables)
            table.Range.HighlightColorIndex = Word.WdColorIndex.wdTurquoise;
        }
      }
      ProcessChapters(chapter.SubChapters);
    }

    private void ThisDocument_Shutdown(object sender, System.EventArgs e)
    {
    }

    #region VSTO Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InternalStartup()
    {
      this.Startup += new System.EventHandler(ThisDocument_Startup);
      this.Shutdown += new System.EventHandler(ThisDocument_Shutdown);
    }

    #endregion
  }
}
