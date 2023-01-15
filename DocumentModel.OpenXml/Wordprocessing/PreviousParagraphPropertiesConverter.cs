using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using FrameProperties = DocumentModel.Wordprocessing.FrameProperties;
using Indentation = DocumentModel.Wordprocessing.Indentation;
using NumberingProperties = DocumentModel.Wordprocessing.NumberingProperties;
using ParagraphBorders = DocumentModel.Wordprocessing.ParagraphBorders;
using PreviousParagraphProperties = DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphProperties;
using Shading = DocumentModel.Wordprocessing.Shading;
using SpacingBetweenLines = DocumentModel.Wordprocessing.SpacingBetweenLines;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Numbering Level Associated Paragraph Properties.
/// </summary>
public static class PreviousParagraphPropertiesConverter
{
  /// <summary>
  ///   ParagraphStyleId.
  /// </summary>
  public static String? GetParagraphStyleId(PreviousParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ParagraphStyleId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetParagraphStyleId(PreviousParagraphProperties? openXmlElement, String? value)
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
  public static Boolean? GetKeepNext(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<KeepNext>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetKeepNext(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetKeepLines(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<KeepLines>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetKeepLines(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetPageBreakBefore(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PageBreakBefore>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetPageBreakBefore(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static FrameProperties? GetFrameProperties(PreviousParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameProperties>();
    if (itemElement != null)
      return FramePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFrameProperties(PreviousParagraphProperties? openXmlElement, FrameProperties? value)
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
  public static Boolean? GetWidowControl(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WidowControl>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWidowControl(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static NumberingProperties? GetNumberingProperties(PreviousParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingProperties>();
    if (itemElement != null)
      return NumberingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingProperties(PreviousParagraphProperties? openXmlElement, NumberingProperties? value)
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
  public static Boolean? GetSuppressLineNumbers(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SuppressLineNumbers>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSuppressLineNumbers(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static ParagraphBorders? GetParagraphBorders(PreviousParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders>();
    if (itemElement != null)
      return ParagraphBordersConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraphBorders(PreviousParagraphProperties? openXmlElement, ParagraphBorders? value)
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
  public static Shading? GetShading(PreviousParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return ShadingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShading(PreviousParagraphProperties? openXmlElement, Shading? value)
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
  public static DocumentModel.Wordprocessing.Tabs? GetTabs(PreviousParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Tabs>();
    if (itemElement != null)
      return TabsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTabs(PreviousParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.Tabs? value)
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
  public static Boolean? GetSuppressAutoHyphens(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SuppressAutoHyphens>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSuppressAutoHyphens(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetKinsoku(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Kinsoku>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetKinsoku(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetWordWrap(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WordWrap>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWordWrap(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetOverflowPunctuation(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<OverflowPunctuation>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetOverflowPunctuation(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetTopLinePunctuation(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TopLinePunctuation>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetTopLinePunctuation(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetAutoSpaceDE(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutoSpaceDE>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAutoSpaceDE(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetAutoSpaceDN(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutoSpaceDN>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAutoSpaceDN(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetBiDi(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BiDi>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBiDi(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetAdjustRightIndent(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AdjustRightIndent>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAdjustRightIndent(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetSnapToGrid(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SnapToGrid>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSnapToGrid(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static SpacingBetweenLines? GetSpacingBetweenLines(PreviousParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines>();
    if (itemElement != null)
      return SpacingBetweenLinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSpacingBetweenLines(PreviousParagraphProperties? openXmlElement, SpacingBetweenLines? value)
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
  public static Indentation? GetIndentation(PreviousParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Indentation>();
    if (itemElement != null)
      return IndentationConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetIndentation(PreviousParagraphProperties? openXmlElement, Indentation? value)
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
  public static Boolean? GetContextualSpacing(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ContextualSpacing>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetContextualSpacing(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetMirrorIndents(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MirrorIndents>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetMirrorIndents(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetSuppressOverlap(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SuppressOverlap>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSuppressOverlap(PreviousParagraphProperties? openXmlElement, Boolean? value)
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
  public static JustificationKind? GetJustification(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Justification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<JustificationValues, JustificationKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetJustification(PreviousParagraphProperties? openXmlElement, JustificationKind? value)
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
  public static TextDirectionKind? GetTextDirection(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextDirection>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TextDirectionValues, TextDirectionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextDirection(PreviousParagraphProperties? openXmlElement, TextDirectionKind? value)
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
  public static VerticalTextAlignmentKind? GetTextAlignment(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextAlignment>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<VerticalTextAlignmentValues, VerticalTextAlignmentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextAlignment(PreviousParagraphProperties? openXmlElement, VerticalTextAlignmentKind? value)
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
  public static TextBoxTightWrapKind? GetTextBoxTightWrap(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextBoxTightWrap>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TextBoxTightWrapValues, TextBoxTightWrapKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextBoxTightWrap(PreviousParagraphProperties? openXmlElement, TextBoxTightWrapKind? value)
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
  public static Int32? GetOutlineLevel(PreviousParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<OutlineLevel>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetOutlineLevel(PreviousParagraphProperties? openXmlElement, Int32? value)
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

  public static DocumentModel.Wordprocessing.PreviousParagraphProperties? CreateModelElement(PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PreviousParagraphProperties();
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
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PreviousParagraphProperties? value)
    where OpenXmlElementType : PreviousParagraphProperties, new()
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
      return openXmlElement;
    }
    return default;
  }
}