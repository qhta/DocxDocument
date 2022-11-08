using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using DocxDocument.Model;

//using DocxToLatex.Converter.Extensions;

//using Polenter.Serialization;

using System.Diagnostics;
using System.IO;
//using System.Runtime.Serialization;
using System.Xml;
using Qhta.OpenXMLTools;
using WP = DocumentFormat.OpenXml.Wordprocessing;

namespace DocxToLatex.Converter.XLDocument.XLLists;

public interface IXLListsRepository
{
  ListProperties GetListProperties(Paragraph p);
}

public class XLListsRepository : IXLListsRepository
{
  private readonly string wordDocumentName;
  private readonly WordprocessingDocument wordDocument;
  //private readonly DocumentFormat.OpenXml.Wordprocessing.Numbering numbering;
  public ListDefinitions ListDefinitions { get; } = new ListDefinitions();
  public Dictionary<Paragraph, ListProperties> ParagraphListPropertiesDictionary { get; }

  public XLListsRepository(WordprocessingDocument document, string documentName)
  {
    this.wordDocumentName = documentName;
    this.wordDocument = document;
    //this.numbering = document.MainDocumentPart.NumberingDefinitionsPart?.Numbering;
    //this.ListDefinitions = ReadListDefinitions(numbering);
    this.ParagraphListPropertiesDictionary = CreateParagraphListPropertiesDictionary(document.MainDocumentPart.Document.Body);
    if (wordDocumentName != null)
    {
      string filename = Path.ChangeExtension(wordDocumentName, "lists.xml");
      using (XmlWriter xmlWriter = XmlWriter.Create(filename, new XmlWriterSettings { Indent = true }))
      {
        XmlSerializer serializer = new XmlSerializer(typeof(ListDefinitions));
        serializer.Serialize(xmlWriter, ListDefinitions);
        //DataContractSerializer serializer = new DataContractSerializer(typeof(XLListDefinitions));
        //serializer.WriteObject(xmlWriter, ListDefinitions);
      }
      //SharpSerializer serializer = new SharpSerializer(new SharpSerializerBinarySettings { AdvancedSettings = new Ad});

    }
  }

  //private XLListDefinitions ReadListDefinitions(DocumentFormat.OpenXml.Wordprocessing.Numbering numbering)
  //{
  //  var listDefinitions = new XLListDefinitions();
  //  if (numbering != null)
  //  {
  //    foreach (var element in numbering.ChildElements)
  //    {
  //      if (element is AbstractNum abstractNum)
  //      {
  //        int numId = abstractNum.AbstractNumberId.Value;
  //        XLMultilevelType multilevelType = (XLMultilevelType)abstractNum.MultiLevelType.Val.Value;
  //        XLListDefinition listDefinition = new XLListDefinition(numId, multilevelType);
  //        listDefinitions.Add(numId, listDefinition);
  //        foreach (var item in abstractNum.Elements<DocumentFormat.OpenXml.Wordprocessing.Level>())
  //        {
  //          var level = new XLListLevel
  //          {
  //            Level = item.LevelIndex?.Value + 1 ?? 0,
  //            StartNumber = item.StartNumberingValue?.Val ?? 0,
  //            RestartLevel = item.LevelRestart?.Val ?? 0,
  //            NumberFormat = (XLNumberFormat)(item.NumberingFormat?.Val?.Value ?? 0),
  //            LevelText = item.LevelText?.Val
  //          };
  //          if (level.LevelText != null)
  //          {
  //            var fontName = item.NumberingSymbolRunProperties?.RunFonts?.Ascii?.Value;
  //            if (fontName == "Symbol" || fontName == "Wingdings" || fontName == "Webdings")
  //            {
  //              var appName = AppDomain.CurrentDomain.BaseDirectory;
  //              string fileName = Path.Combine(appName, "Encodings", fontName + ".enc");
  //              if (StringExtensions.EnsureLoadCharset(fontName, fileName))
  //              {
  //                string str = level.LevelText;
  //                level.LevelText = str.DecodeCharset(fontName);
  //              }
  //            }
  //          }
  //          listDefinition.Levels.Add(level);
  //        }
  //      }
  //    }
  //  }
  //  return listDefinitions;
  //}

  public ListProperties GetListProperties(Paragraph paragraph)
  {
    return (this.ParagraphListPropertiesDictionary != null && this.ParagraphListPropertiesDictionary.ContainsKey(paragraph)) ? this.ParagraphListPropertiesDictionary[paragraph] : null;
  }


  private struct ListKey
  {
    public int ListId;
    public ListType ListType;
    public int NumId;
    public int ANumId;
    public int NumLvl;
    public int OutLvl;
    public static ListKey Empty => new ListKey { ListType = ListType.None, NumId = 0, ANumId = 0, NumLvl = 0, OutLvl = 0 };
  }

  private Dictionary<Paragraph, ListProperties> CreateParagraphListPropertiesDictionary(WP.Body body)
  {
    Dictionary<ListKey, List<Paragraph>> paragraphsListGrouped = GroupNumberedParagraphs(body);

    Dictionary<Paragraph, ListProperties> result = new Dictionary<Paragraph, ListProperties>();
    int lastIndent = 0;
    foreach (var group in paragraphsListGrouped)
    {
      if (group.Key.OutLvl > 0)
        continue; // these groups only separate list groups
      int abstractNumId = group.Key.ANumId;
      var listId = group.Key.ListId;
      int levelId = group.Key.NumLvl;
      if (!ListDefinitions.TryGetValue(listId, out var listDefinition))
      {
        listDefinition = new ListDefinition { ID = listId };
        ListDefinitions.Add(listDefinition);
      }
      listDefinition.UsageCount +=1;
      if (!listDefinition.Levels.TryGetValue(levelId, out var listLevel))
      {
        var wordLevel = wordDocument.GetNumberingLevelDef(abstractNumId, levelId);
        listLevel = new ListLevel
        { ID = levelId,
          Level = levelId,
          StartNumber = wordLevel.StartNumberingValue?.Val ?? 0,
          RestartLevel = wordLevel.LevelRestart?.Val ?? 0,
          NumberingFormat = (DocxDocument.Model.NumberingFormat)(wordLevel.NumberingFormat?.Val?.Value ?? 0),
          LevelText = wordLevel.LevelText?.Val};
        listDefinition.Levels.Add(listLevel);
      }
      List<Paragraph> paragraphsInList = group.Value;
      for (int idx = 0; idx < paragraphsInList.Count; ++idx)
      {
        Paragraph paragraph = paragraphsInList[idx];
        var t = paragraph.InnerText;
        if (t.Contains("linia zagłębiona"))
          Debug.Assert(true);
        //var t = paragraph.InnerText;
        //if (t.Contains("Przypisuj identyfikatory do pozycji w rejestrze"))
        //  Debug.Assert(true);
        int indentLevel = wordDocument.GetNumberingLevel(paragraph);
        bool isStartingEntry = (idx == 0) || (indentLevel>lastIndent);
        listLevel.UsageCount += 1;
        bool isLastParagraphInList = idx == paragraphsInList.Count - 1;
        Paragraph nextParagraph = (isLastParagraphInList) ? paragraph.NextSibling<Paragraph>() : paragraphsInList[idx + 1];
        int nextParagraphIndentLevel = wordDocument.GetNumberingLevel(nextParagraph);
        int isEndingEntries = 0;
        if (nextParagraphIndentLevel < indentLevel)
          isEndingEntries = indentLevel - nextParagraphIndentLevel;
        //else if (indentLevel >lastIndent)
        //{
        //  listDefinition.ListId=;
        //}
        result.Add(paragraph, new ListProperties(listId, listDefinition, indentLevel, isStartingEntry, isEndingEntries));
        lastIndent = indentLevel;
      }
    }

    return result;
  }

  private Dictionary<ListKey, List<Paragraph>> GroupNumberedParagraphs(WP.Body body)
  {
    Dictionary<ListKey, List<Paragraph>> paragraphsListGrouped = new Dictionary<ListKey, List<Paragraph>>();
    ListKey lastKey = default(ListKey);
    List<Paragraph> lastList = new List<Paragraph>();
    int keyId = 0;
    foreach (var item in body.Elements<Paragraph>()
               .Select(paragraph => new
               {
                 NumProps = wordDocument.GetNumberingProperties(paragraph),
                 OutLvl = wordDocument.GetOutlineLevel(paragraph),
                 Paragraph = paragraph
               }).Where(item => item.NumProps != null || item.OutLvl != 0))
    {
      var numId = item.NumProps.NumberingId?.Val?.Value;
      var t = item.Paragraph.InnerText;
      //if (t.Contains("linia zagłębiona"))
      //  Debug.Assert(true);
      ListKey newKey = new ListKey
      {
        ListType = (numId != null) ? GetListType((int)(numId)) : ListType.None,
        NumId = (numId != null) ? (int)(numId) : 0,
        ANumId = (numId != null) ? wordDocument.GetAbstractNumberingId((int)(numId)) ?? 0 : 0,
        NumLvl = wordDocument.GetNumberingLevel(item.NumProps),
        OutLvl = item.OutLvl
      };

      if (newKey.ListType != lastKey.ListType || newKey.NumId != lastKey.NumId || newKey.NumLvl != lastKey.NumLvl || newKey.OutLvl != lastKey.OutLvl)
      {
        newKey.ListId = ++keyId;
        lastKey = newKey;
        paragraphsListGrouped.Add(lastKey, lastList = new List<Paragraph>());
      }
      lastList.Add(item.Paragraph);
    }
    return paragraphsListGrouped;
  }

  //private Dictionary<ListKey, List<Paragraph>> EvaluateGroupEmbedding(Dictionary<ListKey, List<Paragraph>> groups)
  //{

  //}

  private ListType GetListType(int abstractNumId)
  {
    WP.NumberFormatValues numFmtValues = wordDocument.GetListType(abstractNumId);
    switch (numFmtValues)
    {
      case WP.NumberFormatValues.None:
        return ListType.None;

      case WP.NumberFormatValues.Bullet:
        return ListType.Bulleted;

      case WP.NumberFormatValues.Decimal:
        return ListType.Numbered;

      default:
        return ListType.Bulleted;
    }
  }
}