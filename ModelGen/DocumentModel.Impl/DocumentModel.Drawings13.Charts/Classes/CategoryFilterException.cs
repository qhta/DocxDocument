namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the CategoryFilterException Class.
/// </summary>
public class CategoryFilterExceptionImpl: ModelElementImpl, CategoryFilterException
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CategoryFilterExceptionImpl(): base() {}
  
  public CategoryFilterExceptionImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public String? SequenceOfReferences
  {
    get => (System.String?)OpenXmlElement?.SequenceOfReferences?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.SequenceOfReferences != null)
        {
          if (value is not null)
            OpenXmlElement.SequenceOfReferences.Text = value;
          else
            OpenXmlElement.SequenceOfReferences = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.SequenceOfReferences = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings13.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  public UInt32? Explosion
  {
    get => (System.UInt32?)OpenXmlElement?.Explosion?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Explosion != null)
        {
          if (value is not null)
            OpenXmlElement.Explosion.Val = (System.UInt32?)value;
          else
            OpenXmlElement.Explosion = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Explosion = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.Explosion{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// InvertIfNegativeBoolean.
  /// </summary>
  public Boolean? InvertIfNegativeBoolean
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.InvertIfNegativeBoolean>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.InvertIfNegativeBoolean>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.InvertIfNegativeBoolean();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  public Boolean? Bubble3D
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Bubble3D>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Bubble3D>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.Bubble3D();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Drawings13.Charts.Marker? Marker
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataLabel? DataLabel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
