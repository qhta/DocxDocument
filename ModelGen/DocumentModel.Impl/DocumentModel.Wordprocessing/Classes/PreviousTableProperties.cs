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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public DocumentModel.Wordprocessing.TableIndentation? TableIndentation
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.TableBorders? TableBorders
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TableLayout.
  /// </summary>
  public DocumentModel.Wordprocessing.TableLayout? TableLayout
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMarginDefault? TableCellMarginDefault
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TableLook.
  /// </summary>
  public DocumentModel.Wordprocessing.TableLook? TableLook
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
