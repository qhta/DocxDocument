using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using FrameProperties = DocumentModel.Wordprocessing.FrameProperties;
using Indentation = DocumentModel.Wordprocessing.Indentation;
using NumberingProperties = DocumentModel.Wordprocessing.NumberingProperties;
using ParagraphBorders = DocumentModel.Wordprocessing.ParagraphBorders;
using ParagraphPropertiesBaseStyle = DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyle;
using Shading = DocumentModel.Wordprocessing.Shading;
using SpacingBetweenLines = DocumentModel.Wordprocessing.SpacingBetweenLines;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Paragraph Properties.
/// </summary>
public static class ParagraphPropertiesBaseStyleConverter
{
  /// <summary>
  ///   KeepNext.
  /// </summary>
  public static Boolean? GetKeepNext(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<KeepNext>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetKeepNext(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static Boolean? GetKeepLines(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<KeepLines>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetKeepLines(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static Boolean? GetPageBreakBefore(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PageBreakBefore>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetPageBreakBefore(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static FrameProperties? GetFrameProperties(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameProperties>();
    if (itemElement != null)
      return FramePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFrameProperties(ParagraphPropertiesBaseStyle? openXmlElement, FrameProperties? value)
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
  public static Boolean? GetWidowControl(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WidowControl>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWidowControl(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static NumberingProperties? GetNumberingProperties(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingProperties>();
    if (itemElement != null)
      return NumberingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingProperties(ParagraphPropertiesBaseStyle? openXmlElement, NumberingProperties? value)
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
  public static Boolean? GetSuppressLineNumbers(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SuppressLineNumbers>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSuppressLineNumbers(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static ParagraphBorders? GetParagraphBorders(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders>();
    if (itemElement != null)
      return ParagraphBordersConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraphBorders(ParagraphPropertiesBaseStyle? openXmlElement, ParagraphBorders? value)
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
  public static Shading? GetShading(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return ShadingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShading(ParagraphPropertiesBaseStyle? openXmlElement, Shading? value)
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
  public static DocumentModel.Wordprocessing.Tabs? GetTabs(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Tabs>();
    if (itemElement != null)
      return TabsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTabs(ParagraphPropertiesBaseStyle? openXmlElement, DocumentModel.Wordprocessing.Tabs? value)
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
  public static Boolean? GetSuppressAutoHyphens(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SuppressAutoHyphens>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSuppressAutoHyphens(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static Boolean? GetKinsoku(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Kinsoku>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetKinsoku(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static Boolean? GetWordWrap(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WordWrap>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWordWrap(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static Boolean? GetOverflowPunctuation(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<OverflowPunctuation>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetOverflowPunctuation(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static Boolean? GetTopLinePunctuation(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TopLinePunctuation>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetTopLinePunctuation(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static Boolean? GetAutoSpaceDE(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutoSpaceDE>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAutoSpaceDE(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static Boolean? GetAutoSpaceDN(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutoSpaceDN>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAutoSpaceDN(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static Boolean? GetBiDi(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BiDi>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBiDi(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static Boolean? GetAdjustRightIndent(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AdjustRightIndent>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAdjustRightIndent(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static Boolean? GetSnapToGrid(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SnapToGrid>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSnapToGrid(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static SpacingBetweenLines? GetSpacingBetweenLines(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines>();
    if (itemElement != null)
      return SpacingBetweenLinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSpacingBetweenLines(ParagraphPropertiesBaseStyle? openXmlElement, SpacingBetweenLines? value)
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
  public static Indentation? GetIndentation(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Indentation>();
    if (itemElement != null)
      return IndentationConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetIndentation(ParagraphPropertiesBaseStyle? openXmlElement, Indentation? value)
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
  public static Boolean? GetContextualSpacing(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ContextualSpacing>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetContextualSpacing(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static Boolean? GetMirrorIndents(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MirrorIndents>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetMirrorIndents(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static Boolean? GetSuppressOverlap(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SuppressOverlap>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSuppressOverlap(ParagraphPropertiesBaseStyle? openXmlElement, Boolean? value)
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
  public static JustificationKind? GetJustification(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Justification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<JustificationValues, JustificationKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetJustification(ParagraphPropertiesBaseStyle? openXmlElement, JustificationKind? value)
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
  public static TextDirectionKind? GetTextDirection(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextDirection>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TextDirectionValues, TextDirectionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextDirection(ParagraphPropertiesBaseStyle? openXmlElement, TextDirectionKind? value)
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
  public static VerticalTextAlignmentKind? GetTextAlignment(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextAlignment>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<VerticalTextAlignmentValues, VerticalTextAlignmentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextAlignment(ParagraphPropertiesBaseStyle? openXmlElement, VerticalTextAlignmentKind? value)
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
  public static TextBoxTightWrapKind? GetTextBoxTightWrap(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextBoxTightWrap>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TextBoxTightWrapValues, TextBoxTightWrapKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextBoxTightWrap(ParagraphPropertiesBaseStyle? openXmlElement, TextBoxTightWrapKind? value)
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
  public static Int32? GetOutlineLevel(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<OutlineLevel>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetOutlineLevel(ParagraphPropertiesBaseStyle? openXmlElement, Int32? value)
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

  public static DocumentModel.Wordprocessing.ParagraphPropertiesBaseStyle? CreateModelElement(ParagraphPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ParagraphPropertiesBaseStyle();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ParagraphPropertiesBaseStyle? value)
    where OpenXmlElementType : ParagraphPropertiesBaseStyle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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