namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Paragraph Properties.
/// </summary>
public static class ParagraphPropertiesConverter
{
  /// <summary>
  /// ParagraphStyleId.
  /// </summary>
  public static String? GetParagraphStyleId(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphStyleId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetParagraphStyleId(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphStyleId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.ParagraphStyleId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// KeepNext.
  /// </summary>
  public static Boolean? GetKeepNext(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.KeepNext>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetKeepNext(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.KeepNext>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.KeepNext();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// KeepLines.
  /// </summary>
  public static Boolean? GetKeepLines(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.KeepLines>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetKeepLines(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.KeepLines>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.KeepLines();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// PageBreakBefore.
  /// </summary>
  public static Boolean? GetPageBreakBefore(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageBreakBefore>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetPageBreakBefore(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageBreakBefore>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.PageBreakBefore();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// FrameProperties.
  /// </summary>
  public static DocumentModel.Wordprocessing.FrameProperties? GetFrameProperties(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FramePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFrameProperties(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.FrameProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.FramePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FrameProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// WidowControl.
  /// </summary>
  public static Boolean? GetWidowControl(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WidowControl>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetWidowControl(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WidowControl>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.WidowControl();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// NumberingProperties.
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberingProperties? GetNumberingProperties(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.NumberingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberingProperties(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.NumberingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.NumberingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// SuppressLineNumbers.
  /// </summary>
  public static Boolean? GetSuppressLineNumbers(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressLineNumbers>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSuppressLineNumbers(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressLineNumbers>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SuppressLineNumbers();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ParagraphBorders.
  /// </summary>
  public static DocumentModel.Wordprocessing.ParagraphBorders? GetParagraphBorders(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ParagraphBordersConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetParagraphBorders(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.ParagraphBorders? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ParagraphBordersConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public static DocumentModel.Wordprocessing.Shading? GetShading(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShading(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.Shading? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Shading>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public static DocumentModel.Wordprocessing.Tabs? GetTabs(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Tabs>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TabsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTabs(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.Tabs? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Tabs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TabsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Tabs>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// SuppressAutoHyphens.
  /// </summary>
  public static Boolean? GetSuppressAutoHyphens(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressAutoHyphens>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSuppressAutoHyphens(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressAutoHyphens>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SuppressAutoHyphens();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Kinsoku.
  /// </summary>
  public static Boolean? GetKinsoku(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Kinsoku>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetKinsoku(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Kinsoku>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Kinsoku();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// WordWrap.
  /// </summary>
  public static Boolean? GetWordWrap(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WordWrap>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetWordWrap(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WordWrap>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.WordWrap();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// OverflowPunctuation.
  /// </summary>
  public static Boolean? GetOverflowPunctuation(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.OverflowPunctuation>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetOverflowPunctuation(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.OverflowPunctuation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.OverflowPunctuation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// TopLinePunctuation.
  /// </summary>
  public static Boolean? GetTopLinePunctuation(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TopLinePunctuation>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetTopLinePunctuation(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TopLinePunctuation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.TopLinePunctuation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// AutoSpaceDE.
  /// </summary>
  public static Boolean? GetAutoSpaceDE(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDE>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAutoSpaceDE(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDE>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDE();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// AutoSpaceDN.
  /// </summary>
  public static Boolean? GetAutoSpaceDN(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDN>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAutoSpaceDN(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDN>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDN();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// BiDi.
  /// </summary>
  public static Boolean? GetBiDi(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BiDi>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBiDi(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BiDi>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.BiDi();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// AdjustRightIndent.
  /// </summary>
  public static Boolean? GetAdjustRightIndent(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AdjustRightIndent>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAdjustRightIndent(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AdjustRightIndent>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AdjustRightIndent();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  public static Boolean? GetSnapToGrid(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSnapToGrid(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SnapToGrid();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// SpacingBetweenLines.
  /// </summary>
  public static DocumentModel.Wordprocessing.SpacingBetweenLines? GetSpacingBetweenLines(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SpacingBetweenLinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSpacingBetweenLines(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.SpacingBetweenLines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.SpacingBetweenLinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Indentation.
  /// </summary>
  public static DocumentModel.Wordprocessing.Indentation? GetIndentation(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Indentation>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.IndentationConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetIndentation(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.Indentation? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Indentation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.IndentationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Indentation>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ContextualSpacing.
  /// </summary>
  public static Boolean? GetContextualSpacing(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ContextualSpacing>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetContextualSpacing(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ContextualSpacing>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.ContextualSpacing();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// MirrorIndents.
  /// </summary>
  public static Boolean? GetMirrorIndents(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MirrorIndents>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetMirrorIndents(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MirrorIndents>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.MirrorIndents();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// SuppressOverlap.
  /// </summary>
  public static Boolean? GetSuppressOverlap(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressOverlap>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSuppressOverlap(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressOverlap>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SuppressOverlap();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public static DocumentModel.Wordprocessing.JustificationKind? GetJustification(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Justification>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DocumentModel.Wordprocessing.JustificationKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetJustification(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.JustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Justification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Justification, DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DocumentModel.Wordprocessing.JustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public static DocumentModel.Wordprocessing.TextDirectionKind? GetTextDirection(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DocumentModel.Wordprocessing.TextDirectionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTextDirection(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.TextDirectionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextDirection, DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DocumentModel.Wordprocessing.TextDirectionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// TextAlignment.
  /// </summary>
  public static DocumentModel.Wordprocessing.VerticalTextAlignmentKind? GetTextAlignment(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextAlignment>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DocumentModel.Wordprocessing.VerticalTextAlignmentKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTextAlignment(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.VerticalTextAlignmentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextAlignment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextAlignment, DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DocumentModel.Wordprocessing.VerticalTextAlignmentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// TextBoxTightWrap.
  /// </summary>
  public static DocumentModel.Wordprocessing.TextBoxTightWrapKind? GetTextBoxTightWrap(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrap>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DocumentModel.Wordprocessing.TextBoxTightWrapKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTextBoxTightWrap(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.TextBoxTightWrapKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrap, DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DocumentModel.Wordprocessing.TextBoxTightWrapKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// OutlineLevel.
  /// </summary>
  public static Int32? GetOutlineLevel(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.OutlineLevel>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetOutlineLevel(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.OutlineLevel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.OutlineLevel{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// DivId.
  /// </summary>
  public static String? GetDivId(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.DivId");
  }
  
  public static void SetDivId(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.DivId");
  }
  
  /// <summary>
  /// ConditionalFormatStyle.
  /// </summary>
  public static DocumentModel.Wordprocessing.ConditionalFormatStyle? GetConditionalFormatStyle(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ConditionalFormatStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetConditionalFormatStyle(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.ConditionalFormatStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ConditionalFormatStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Run Properties for the Paragraph Mark.
  /// </summary>
  public static DocumentModel.Wordprocessing.ParagraphMarkRunProperties? GetParagraphMarkRunProperties(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetParagraphMarkRunProperties(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.ParagraphMarkRunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Section Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.SectionProperties? GetSectionProperties(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SectionProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SectionPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSectionProperties(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.SectionProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SectionProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.SectionPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ParagraphPropertiesChange.
  /// </summary>
  public static DocumentModel.Wordprocessing.ParagraphPropertiesChange? GetParagraphPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ParagraphPropertiesChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetParagraphPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement, DocumentModel.Wordprocessing.ParagraphPropertiesChange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ParagraphPropertiesChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.ParagraphProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, new()
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
