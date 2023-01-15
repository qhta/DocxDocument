using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using ConditionalFormatStyle = DocumentModel.Wordprocessing.ConditionalFormatStyle;
using FrameProperties = DocumentModel.Wordprocessing.FrameProperties;
using Indentation = DocumentModel.Wordprocessing.Indentation;
using NumberingProperties = DocumentModel.Wordprocessing.NumberingProperties;
using ParagraphBorders = DocumentModel.Wordprocessing.ParagraphBorders;
using ParagraphMarkRunProperties = DocumentModel.Wordprocessing.ParagraphMarkRunProperties;
using ParagraphProperties = DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties;
using ParagraphPropertiesChange = DocumentModel.Wordprocessing.ParagraphPropertiesChange;
using SectionProperties = DocumentModel.Wordprocessing.SectionProperties;
using Shading = DocumentModel.Wordprocessing.Shading;
using SpacingBetweenLines = DocumentModel.Wordprocessing.SpacingBetweenLines;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Paragraph Properties.
/// </summary>
public static class ParagraphPropertiesConverter
{
  /// <summary>
  ///   ParagraphStyleId.
  /// </summary>
  public static String? GetParagraphStyleId(ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ParagraphStyleId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetParagraphStyleId(ParagraphProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ParagraphStyleId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ParagraphStyleId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   KeepNext.
  /// </summary>
  public static Boolean? GetKeepNext(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<KeepNext>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetKeepNext(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<KeepNext>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new KeepNext();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   KeepLines.
  /// </summary>
  public static Boolean? GetKeepLines(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<KeepLines>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetKeepLines(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<KeepLines>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new KeepLines();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   PageBreakBefore.
  /// </summary>
  public static Boolean? GetPageBreakBefore(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PageBreakBefore>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetPageBreakBefore(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<PageBreakBefore>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new PageBreakBefore();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FrameProperties.
  /// </summary>
  public static FrameProperties? GetFrameProperties(ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameProperties>();
    if (itemElement != null)
      return FramePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFrameProperties(ParagraphProperties? openXmlElement, FrameProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FramePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FrameProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   WidowControl.
  /// </summary>
  public static Boolean? GetWidowControl(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WidowControl>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWidowControl(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<WidowControl>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new WidowControl();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   NumberingProperties.
  /// </summary>
  public static NumberingProperties? GetNumberingProperties(ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingProperties>();
    if (itemElement != null)
      return NumberingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingProperties(ParagraphProperties? openXmlElement, NumberingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SuppressLineNumbers.
  /// </summary>
  public static Boolean? GetSuppressLineNumbers(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SuppressLineNumbers>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSuppressLineNumbers(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SuppressLineNumbers>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SuppressLineNumbers();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ParagraphBorders.
  /// </summary>
  public static ParagraphBorders? GetParagraphBorders(ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders>();
    if (itemElement != null)
      return ParagraphBordersConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraphBorders(ParagraphProperties? openXmlElement, ParagraphBorders? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphBordersConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shading.
  /// </summary>
  public static Shading? GetShading(ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return ShadingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShading(ParagraphProperties? openXmlElement, Shading? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShadingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Shading>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Tabs.
  /// </summary>
  public static DocumentModel.Wordprocessing.Tabs? GetTabs(ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Tabs>();
    if (itemElement != null)
      return TabsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTabs(ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.Tabs? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Tabs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TabsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Tabs>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SuppressAutoHyphens.
  /// </summary>
  public static Boolean? GetSuppressAutoHyphens(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SuppressAutoHyphens>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSuppressAutoHyphens(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SuppressAutoHyphens>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SuppressAutoHyphens();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Kinsoku.
  /// </summary>
  public static Boolean? GetKinsoku(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Kinsoku>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetKinsoku(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Kinsoku>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Kinsoku();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   WordWrap.
  /// </summary>
  public static Boolean? GetWordWrap(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WordWrap>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWordWrap(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<WordWrap>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new WordWrap();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   OverflowPunctuation.
  /// </summary>
  public static Boolean? GetOverflowPunctuation(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<OverflowPunctuation>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetOverflowPunctuation(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<OverflowPunctuation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new OverflowPunctuation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TopLinePunctuation.
  /// </summary>
  public static Boolean? GetTopLinePunctuation(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TopLinePunctuation>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetTopLinePunctuation(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<TopLinePunctuation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new TopLinePunctuation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   AutoSpaceDE.
  /// </summary>
  public static Boolean? GetAutoSpaceDE(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutoSpaceDE>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAutoSpaceDE(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AutoSpaceDE>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AutoSpaceDE();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   AutoSpaceDN.
  /// </summary>
  public static Boolean? GetAutoSpaceDN(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutoSpaceDN>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAutoSpaceDN(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AutoSpaceDN>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AutoSpaceDN();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   BiDi.
  /// </summary>
  public static Boolean? GetBiDi(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BiDi>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBiDi(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BiDi>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BiDi();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   AdjustRightIndent.
  /// </summary>
  public static Boolean? GetAdjustRightIndent(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AdjustRightIndent>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAdjustRightIndent(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AdjustRightIndent>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AdjustRightIndent();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SnapToGrid.
  /// </summary>
  public static Boolean? GetSnapToGrid(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SnapToGrid>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSnapToGrid(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SnapToGrid>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SnapToGrid();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SpacingBetweenLines.
  /// </summary>
  public static SpacingBetweenLines? GetSpacingBetweenLines(ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines>();
    if (itemElement != null)
      return SpacingBetweenLinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSpacingBetweenLines(ParagraphProperties? openXmlElement, SpacingBetweenLines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SpacingBetweenLinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Indentation.
  /// </summary>
  public static Indentation? GetIndentation(ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Indentation>();
    if (itemElement != null)
      return IndentationConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetIndentation(ParagraphProperties? openXmlElement, Indentation? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Indentation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = IndentationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Indentation>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ContextualSpacing.
  /// </summary>
  public static Boolean? GetContextualSpacing(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ContextualSpacing>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetContextualSpacing(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ContextualSpacing>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ContextualSpacing();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   MirrorIndents.
  /// </summary>
  public static Boolean? GetMirrorIndents(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MirrorIndents>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetMirrorIndents(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<MirrorIndents>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new MirrorIndents();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SuppressOverlap.
  /// </summary>
  public static Boolean? GetSuppressOverlap(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SuppressOverlap>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSuppressOverlap(ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SuppressOverlap>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SuppressOverlap();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Justification.
  /// </summary>
  public static JustificationKind? GetJustification(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Justification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<JustificationValues, JustificationKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetJustification(ParagraphProperties? openXmlElement, JustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Justification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Justification, JustificationValues, JustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TextDirection.
  /// </summary>
  public static TextDirectionKind? GetTextDirection(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextDirection>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TextDirectionValues, TextDirectionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextDirection(ParagraphProperties? openXmlElement, TextDirectionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextDirection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<TextDirection, TextDirectionValues, TextDirectionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TextAlignment.
  /// </summary>
  public static VerticalTextAlignmentKind? GetTextAlignment(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextAlignment>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<VerticalTextAlignmentValues, VerticalTextAlignmentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextAlignment(ParagraphProperties? openXmlElement, VerticalTextAlignmentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextAlignment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<TextAlignment, VerticalTextAlignmentValues, VerticalTextAlignmentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TextBoxTightWrap.
  /// </summary>
  public static TextBoxTightWrapKind? GetTextBoxTightWrap(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextBoxTightWrap>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TextBoxTightWrapValues, TextBoxTightWrapKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextBoxTightWrap(ParagraphProperties? openXmlElement, TextBoxTightWrapKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextBoxTightWrap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<TextBoxTightWrap, TextBoxTightWrapValues, TextBoxTightWrapKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   OutlineLevel.
  /// </summary>
  public static Int32? GetOutlineLevel(ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<OutlineLevel>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetOutlineLevel(ParagraphProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<OutlineLevel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new OutlineLevel { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DivId.
  /// </summary>
  public static String? GetDivId(ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DivId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDivId(ParagraphProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DivId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DivId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ConditionalFormatStyle.
  /// </summary>
  public static ConditionalFormatStyle? GetConditionalFormatStyle(ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
    if (itemElement != null)
      return ConditionalFormatStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConditionalFormatStyle(ParagraphProperties? openXmlElement, ConditionalFormatStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConditionalFormatStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Run Properties for the Paragraph Mark.
  /// </summary>
  public static ParagraphMarkRunProperties? GetParagraphMarkRunProperties(ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties>();
    if (itemElement != null)
      return ParagraphMarkRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraphMarkRunProperties(ParagraphProperties? openXmlElement, ParagraphMarkRunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphMarkRunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Section Properties.
  /// </summary>
  public static SectionProperties? GetSectionProperties(ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SectionProperties>();
    if (itemElement != null)
      return SectionPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSectionProperties(ParagraphProperties? openXmlElement, SectionProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SectionProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SectionPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ParagraphPropertiesChange.
  /// </summary>
  public static ParagraphPropertiesChange? GetParagraphPropertiesChange(ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange>();
    if (itemElement != null)
      return ParagraphPropertiesChangeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraphPropertiesChange(ParagraphProperties? openXmlElement, ParagraphPropertiesChange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphPropertiesChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.ParagraphProperties? CreateModelElement(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ParagraphProperties();
      value.ParagraphStyleId = GetParagraphStyleId(openXmlElement);
      value.KeepNext = GetKeepNext(openXmlElement);
      value.KeepLines = GetKeepLines(openXmlElement);
      value.PageBreakBefore = GetPageBreakBefore(openXmlElement);
      value.FrameProperties = GetFrameProperties(openXmlElement);
      value.WidowControl = GetWidowControl(openXmlElement);
      value.NumberingProperties = GetNumberingProperties(openXmlElement);
      value.SuppressLineNumbers = GetSuppressLineNumbers(openXmlElement);
      value.ParagraphBorders = GetParagraphBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.Tabs = GetTabs(openXmlElement);
      value.SuppressAutoHyphens = GetSuppressAutoHyphens(openXmlElement);
      value.Kinsoku = GetKinsoku(openXmlElement);
      value.WordWrap = GetWordWrap(openXmlElement);
      value.OverflowPunctuation = GetOverflowPunctuation(openXmlElement);
      value.TopLinePunctuation = GetTopLinePunctuation(openXmlElement);
      value.AutoSpaceDE = GetAutoSpaceDE(openXmlElement);
      value.AutoSpaceDN = GetAutoSpaceDN(openXmlElement);
      value.BiDi = GetBiDi(openXmlElement);
      value.AdjustRightIndent = GetAdjustRightIndent(openXmlElement);
      value.SnapToGrid = GetSnapToGrid(openXmlElement);
      value.SpacingBetweenLines = GetSpacingBetweenLines(openXmlElement);
      value.Indentation = GetIndentation(openXmlElement);
      value.ContextualSpacing = GetContextualSpacing(openXmlElement);
      value.MirrorIndents = GetMirrorIndents(openXmlElement);
      value.SuppressOverlap = GetSuppressOverlap(openXmlElement);
      value.Justification = GetJustification(openXmlElement);
      value.TextDirection = GetTextDirection(openXmlElement);
      value.TextAlignment = GetTextAlignment(openXmlElement);
      value.TextBoxTightWrap = GetTextBoxTightWrap(openXmlElement);
      value.OutlineLevel = GetOutlineLevel(openXmlElement);
      value.DivId = GetDivId(openXmlElement);
      value.ConditionalFormatStyle = GetConditionalFormatStyle(openXmlElement);
      value.ParagraphMarkRunProperties = GetParagraphMarkRunProperties(openXmlElement);
      value.SectionProperties = GetSectionProperties(openXmlElement);
      value.ParagraphPropertiesChange = GetParagraphPropertiesChange(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ParagraphProperties? value)
    where OpenXmlElementType : ParagraphProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParagraphStyleId(openXmlElement, value?.ParagraphStyleId);
      SetKeepNext(openXmlElement, value?.KeepNext);
      SetKeepLines(openXmlElement, value?.KeepLines);
      SetPageBreakBefore(openXmlElement, value?.PageBreakBefore);
      SetFrameProperties(openXmlElement, value?.FrameProperties);
      SetWidowControl(openXmlElement, value?.WidowControl);
      SetNumberingProperties(openXmlElement, value?.NumberingProperties);
      SetSuppressLineNumbers(openXmlElement, value?.SuppressLineNumbers);
      SetParagraphBorders(openXmlElement, value?.ParagraphBorders);
      SetShading(openXmlElement, value?.Shading);
      SetTabs(openXmlElement, value?.Tabs);
      SetSuppressAutoHyphens(openXmlElement, value?.SuppressAutoHyphens);
      SetKinsoku(openXmlElement, value?.Kinsoku);
      SetWordWrap(openXmlElement, value?.WordWrap);
      SetOverflowPunctuation(openXmlElement, value?.OverflowPunctuation);
      SetTopLinePunctuation(openXmlElement, value?.TopLinePunctuation);
      SetAutoSpaceDE(openXmlElement, value?.AutoSpaceDE);
      SetAutoSpaceDN(openXmlElement, value?.AutoSpaceDN);
      SetBiDi(openXmlElement, value?.BiDi);
      SetAdjustRightIndent(openXmlElement, value?.AdjustRightIndent);
      SetSnapToGrid(openXmlElement, value?.SnapToGrid);
      SetSpacingBetweenLines(openXmlElement, value?.SpacingBetweenLines);
      SetIndentation(openXmlElement, value?.Indentation);
      SetContextualSpacing(openXmlElement, value?.ContextualSpacing);
      SetMirrorIndents(openXmlElement, value?.MirrorIndents);
      SetSuppressOverlap(openXmlElement, value?.SuppressOverlap);
      SetJustification(openXmlElement, value?.Justification);
      SetTextDirection(openXmlElement, value?.TextDirection);
      SetTextAlignment(openXmlElement, value?.TextAlignment);
      SetTextBoxTightWrap(openXmlElement, value?.TextBoxTightWrap);
      SetOutlineLevel(openXmlElement, value?.OutlineLevel);
      SetDivId(openXmlElement, value?.DivId);
      SetConditionalFormatStyle(openXmlElement, value?.ConditionalFormatStyle);
      SetParagraphMarkRunProperties(openXmlElement, value?.ParagraphMarkRunProperties);
      SetSectionProperties(openXmlElement, value?.SectionProperties);
      SetParagraphPropertiesChange(openXmlElement, value?.ParagraphPropertiesChange);
      return openXmlElement;
    }
    return default;
  }
}