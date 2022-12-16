namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Properties.
/// </summary>
public class PreviousTablePropertiesImpl: ModelElementImpl, PreviousTableProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.PreviousTableProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PreviousTableProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PreviousTablePropertiesImpl(): base() {}
  
  public PreviousTablePropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.PreviousTableProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// TableStyle.
  /// </summary>
  public String? TableStyle
  {
    get => (System.String?)OpenXmlElement?.TableStyle?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TableStyle != null)
        {
          if (value is not null)
            OpenXmlElement.TableStyle.Val = (System.String?)value;
          else
            OpenXmlElement.TableStyle = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TableStyle = new DocumentFormat.OpenXml.Wordprocessing.TableStyle{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TablePositionProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.TablePositionProperties? TablePositionProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TablePositionPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TablePositionPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TableOverlap.
  /// </summary>
  public DocumentModel.Wordprocessing.TableOverlapKind? TableOverlap
  {
    get => (DocumentModel.Wordprocessing.TableOverlapKind?)OpenXmlElement?.TableOverlap?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TableOverlap != null)
        {
          if (value is not null)
            OpenXmlElement.TableOverlap.Val = (DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues?)value;
          else
            OpenXmlElement.TableOverlap = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TableOverlap = new DocumentFormat.OpenXml.Wordprocessing.TableOverlap{ Val = (DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// BiDiVisual.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? BiDiVisual
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.BiDiVisual?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.BiDiVisual != null)
        {
          if (value is not null)
            OpenXmlElement.BiDiVisual.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.BiDiVisual = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.BiDiVisual = new DocumentFormat.OpenXml.Wordprocessing.BiDiVisual{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TableWidth.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableWidth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableWidthTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableWidthTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  public DocumentModel.Wordprocessing.TableRowAlignmentKind? TableJustification
  {
    get => (DocumentModel.Wordprocessing.TableRowAlignmentKind?)OpenXmlElement?.TableJustification?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TableJustification != null)
        {
          if (value is not null)
            OpenXmlElement.TableJustification.Val = (DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues?)value;
          else
            OpenXmlElement.TableJustification = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TableJustification = new DocumentFormat.OpenXml.Wordprocessing.TableJustification{ Val = (DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableCellSpacing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableWidthTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableWidthTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public DocumentModel.Wordprocessing.TableIndentation? TableIndentation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableIndentationImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableIndentationImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.TableBorders? TableBorders
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableBorders>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableBordersImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableBorders>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableBordersImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ShadingImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ShadingImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TableLayout.
  /// </summary>
  public DocumentModel.Wordprocessing.TableLayout? TableLayout
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLayout>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableLayoutImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLayout>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableLayoutImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMarginDefault? TableCellMarginDefault
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableCellMarginDefaultImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableCellMarginDefaultImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TableLook.
  /// </summary>
  public DocumentModel.Wordprocessing.TableLook? TableLook
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLook>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableLookImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLook>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableLookImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TableCaption, this property is only available in Office 2010 and later..
  /// </summary>
  public String? TableCaption
  {
    get => (System.String?)OpenXmlElement?.TableCaption?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TableCaption != null)
        {
          if (value is not null)
            OpenXmlElement.TableCaption.Val = (System.String?)value;
          else
            OpenXmlElement.TableCaption = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TableCaption = new DocumentFormat.OpenXml.Wordprocessing.TableCaption{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TableDescription, this property is only available in Office 2010 and later..
  /// </summary>
  public String? TableDescription
  {
    get => (System.String?)OpenXmlElement?.TableDescription?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TableDescription != null)
        {
          if (value is not null)
            OpenXmlElement.TableDescription.Val = (System.String?)value;
          else
            OpenXmlElement.TableDescription = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TableDescription = new DocumentFormat.OpenXml.Wordprocessing.TableDescription{ Val = (System.String?)value };
        }
      }
    }
  }
  
}
