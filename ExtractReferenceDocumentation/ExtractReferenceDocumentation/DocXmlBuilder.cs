#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

using ModelDocumentation;

using ModelGenDataConfig;

using Word = Microsoft.Office.Interop.Word;

namespace ExtractReferenceDocumentation;
internal class DocXmlBuilder
{
  public DocXmlBuilder()
  {
    ModelConfig.Instance.LoadData();
  }

  public ModelDoc ModelDoc { get; private set; } = new ModelDoc();
  public NamespaceDoc? NamespaceDoc { get; private set; }

  public void ProcessDocument(Word.Document document)
  {
    var chapters = GetChapters(document);
    ModelDoc = new ModelDoc();
    ProcessChapters(chapters);
    ModelDoc.SaveData();
    ModelDoc.LoadData();
  }


  private List<Chapter> GetChapters(Word.Document document)
  {
    var chapters = new List<Chapter>();
    try
    {
      Chapter? chapter = null;
      var priorLevel = 0;
      var endDoc = document.StoryRanges[Word.WdStoryType.wdMainTextStory].End;
      var para = document.Paragraphs.First;
      while (para != null)
      {
        var text = para.Range.Text.Trim();
        //Debug.WriteLine(text);
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
    catch (Exception ex)
    {
      MessageBox.Show(ex.Message);
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
      //heading.Range.HighlightColorIndex = Word.WdColorIndex.wdBrightGreen;
      chapter.Namespace = ns;
      if (!ModelDoc.Namespaces.TryGetValue(ns, out var namespaceDoc))
      {
        namespaceDoc = new NamespaceDoc(ns);
        ModelDoc.Namespaces.Add(namespaceDoc);
      }
      NamespaceDoc = namespaceDoc;
    }
    else
    {
      if (chapter.SubChapters.Count == 0)
      {
        try
        {
          if (NamespaceDoc == null)
            throw new NullReferenceException("NamespaceDoc not initialized");
          string tag = text;
          string? name = null;
          (tag, name) = SplitTagAndName(text);
          var typeDoc = new TypeDoc(tag, name);
          //// Do not check this. It is a normal situation.
          //if (typeName!=null)
          //  if (NamespaceDoc.Types.ContainsTagAndName(tag, typeName))
          //    throw new DuplicateNameException($"TypeDoc \"{tag} ({typeName})\" already registered for namespace {NamespaceDoc.Name}");
          NamespaceDoc.Types.Add(typeDoc);
          if (chapter.Paragraphs.Count > 0)
          {
            var summary = new Summary();
            foreach (var para in chapter.Paragraphs)
            {
              var paraText = para.Range.Text.Trim();
              if (paraText != "")
                summary.Add(paraText);
            }
            typeDoc.Summary = summary;
          }
          if (chapter.Tables.Count > 0)
          {
            var properties = new ModelDocumentation.Properties();
            foreach (var table in chapter.Tables)
            {
              if (table.Columns.Count == 2)
              {
                for (int i = 2; i <= table.Rows.Count; i++)
                {
                  var row = table.Rows[i];
                  var cell1 = row.Cells[1];
                  var tagAndNameString = "";
                  foreach (var para in cell1.Range.Paragraphs.Cast<Word.Paragraph>())
                    tagAndNameString += para.Range.Text.Trim();
                  if (tagAndNameString.EndsWith("\a"))
                    tagAndNameString = tagAndNameString.Substring(0, tagAndNameString.Length - 1);
                  var cell2 = row.Cells[2];
                  var summary = new Summary();
                  var summaryString = "";
                  foreach (var para in cell2.Range.Paragraphs.Cast<Word.Paragraph>())
                    summaryString += para.Range.Text.Trim();
                  if (summaryString.EndsWith("\a"))
                    summaryString = summaryString.Substring(0, summaryString.Length - 1);
                  (tag,name)=SplitTagAndName(tagAndNameString);
                  var propDoc = new PropDoc(tag, name);
                  properties.Add(propDoc);
                }
              }
            }
            typeDoc.Properties = properties;
          }

          //heading.Range.HighlightColorIndex = Word.WdColorIndex.wdYellow;
          //foreach (var para in chapter.Paragraphs)
          //  para.Range.HighlightColorIndex = Word.WdColorIndex.wdPink;
          //foreach (var table in chapter.Tables)
          //  table.Range.HighlightColorIndex = Word.WdColorIndex.wdTurquoise;
        }
        catch (Exception ex)
        {
          Debug.WriteLine($"Exception thrown {ex.Message}");
        }
      }
    }
    ProcessChapters(chapter.SubChapters);
  }

  private (string, string?) SplitTagAndName(string text)
  {
    string tag = text;
    string? name = null;
    var k = text.IndexOf('(');
    if (k > 0)
    {
      tag = text.Substring(0, k).TrimEnd();
      name = text.Substring(k + 1).Trim();
      if (name.EndsWith(")"))
        name = name.Substring(0, name.Length - 1).TrimEnd();
    }
    return (tag, name);
  }
}
