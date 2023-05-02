namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   This class does not exists in wordprocessing document. 
///   In OpenXml sections are represented by SectionProperties elements only.
///   Each document body has one SectionProperties element at the end. This element represents properties of the last section of the document.
///   Other SectionProperties are contained in paragraphs and represent the properties of just ended sections.
/// </summary>
public class Section : LinkedList<IStoryContent>
{
  public SectionProperties Properties { get; set; } = null!;

  /// <summary>
  /// Inserts body elements from specified index backward to this section.
  /// Iterates until a paragraph with SectionProperties is found.
  /// </summary>
  /// <returns></returns>
  public int FillBackward(BodyType aBody, int index)
  {
    while (index >= 0 && index < aBody.Count)
    {
      var item = aBody[index];
      if (item is Paragraph paragraph && paragraph.ParagraphProperties?.SectionProperties!=null)
        break;
      AddFirst(item);
      index--;
    }
    return index;
  }

  public void Add(IStoryContent element)
  {
    AddLast(element);
  }

  /// <summary>
  /// Clean Section Properties.
  /// </summary>
  public void CleanProperties(SectionPropertyMask mask = SectionPropertyMask.All)
  {
    if (mask.HasFlag(SectionPropertyMask.HeaderReference))
      Properties.HeaderReferences?.Clear();

    if (mask.HasFlag(SectionPropertyMask.FooterReference))
      Properties.FooterReferences?.Clear();

    if (mask.HasFlag(SectionPropertyMask.FootnoteProperties))
      Properties.FootnoteProperties = null;

    if (mask.HasFlag(SectionPropertyMask.EndnoteProperties))
      Properties.EndnoteProperties = null;

    if (mask.HasFlag(SectionPropertyMask.SectionType))
      Properties.SectionType = null;

    if (mask.HasFlag(SectionPropertyMask.PageSize))
      Properties.PageSize = null;

    if (mask.HasFlag(SectionPropertyMask.PageMargin))
      Properties.PageMargin = null;

    if (mask.HasFlag(SectionPropertyMask.PaperSource))
      Properties.PaperSource = null;

    if (mask.HasFlag(SectionPropertyMask.PageBorders))
      Properties.PageBorders = null;

    if (mask.HasFlag(SectionPropertyMask.LineNumberType))
      Properties.LineNumberType = null;

    if (mask.HasFlag(SectionPropertyMask.PageNumberType))
      Properties.PageNumberType = null;

    if (mask.HasFlag(SectionPropertyMask.Columns))
      Properties.Columns = null;

    if (mask.HasFlag(SectionPropertyMask.FormProtection))
      Properties.FormProtection = null;

    if (mask.HasFlag(SectionPropertyMask.VerticalTextAlignmentOnPage))
      Properties.VerticalTextAlignmentOnPage = null;

    if (mask.HasFlag(SectionPropertyMask.NoEndnote))
      Properties.NoEndnote = null;

    if (mask.HasFlag(SectionPropertyMask.TitlePage))
      Properties.TitlePage = null;

    if (mask.HasFlag(SectionPropertyMask.TextDirection))
      Properties.TextDirection = null;

    if (mask.HasFlag(SectionPropertyMask.BiDi))
      Properties.BiDi = null;

    if (mask.HasFlag(SectionPropertyMask.GutterOnRight))
      Properties.GutterOnRight = null;

    if (mask.HasFlag(SectionPropertyMask.DocGrid))
      Properties.DocGrid = null;

    if (mask.HasFlag(SectionPropertyMask.PrinterSettingsReference))
      Properties.PrinterSettingsReference = null;

    if (mask.HasFlag(SectionPropertyMask.FootnoteColumns))
      Properties.FootnoteColumns = null;
    
    if (mask.HasFlag(SectionPropertyMask.SectionPropertiesChange))
      Properties.SectionPropertiesChange = null;

  }

}