namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// 3-D Shape Properties.
/// </summary>
public class Shape3DImpl: ModelElementImpl, Shape3D
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Shape3DImpl(): base() {}
  
  public Shape3DImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Shape Depth
  /// </summary>
  public Int64? Z
  {
    get => (System.Int64?)OpenXmlElement?.Z?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Z = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  public Int64? ExtrusionHeight
  {
    get => (System.Int64?)OpenXmlElement?.ExtrusionHeight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ExtrusionHeight = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  public Int64? ContourWidth
  {
    get => (System.Int64?)OpenXmlElement?.ContourWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ContourWidth = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  public DocumentModel.Drawings.PresetMaterialKind? PresetMaterial
  {
    get => (DocumentModel.Drawings.PresetMaterialKind?)OpenXmlElement?.PresetMaterial?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresetMaterial = (DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues?)value;
    }
  }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  public DocumentModel.Drawings.BevelType? BevelTop
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BevelType>();
        if (item != null)
          return new DocumentModel.Drawings.BevelTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BevelType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.BevelTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Bottom Bevel.
  /// </summary>
  public DocumentModel.Drawings.BevelType? BevelBottom
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BevelType>();
        if (item != null)
          return new DocumentModel.Drawings.BevelTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BevelType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.BevelTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Extrusion Color.
  /// </summary>
  public DocumentModel.Drawings.ExtrusionColor? ExtrusionColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
        if (item != null)
          return new DocumentModel.Drawings.ExtrusionColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ExtrusionColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Contour Color.
  /// </summary>
  public DocumentModel.Drawings.ContourColor? ContourColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ContourColor>();
        if (item != null)
          return new DocumentModel.Drawings.ContourColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ContourColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ContourColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
