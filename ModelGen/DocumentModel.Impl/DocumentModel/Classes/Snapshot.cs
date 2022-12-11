namespace DocumentModel;

/// <summary>
/// Defines the Snapshot Class.
/// </summary>
public class SnapshotImpl: ModelElementImpl, Snapshot
{
  public DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SnapshotImpl(): base() {}
  
  public SnapshotImpl(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public String? Embed
  {
    get => (String?)OpenXmlElement?.Embed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Embed = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public String? Link
  {
    get => (String?)OpenXmlElement?.Link?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Link = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  public DocumentModel.Drawings.BlipCompressionKind? CompressionState
  {
    get => (DocumentModel.Drawings.BlipCompressionKind?)OpenXmlElement?.CompressionState?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CompressionState = (DocumentFormat.OpenXml.Drawing.BlipCompressionValues?)value;
    }
  }
  
  public DocumentModel.Drawings.AlphaBiLevel? AlphaBiLevel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Boolean? AlphaCeiling
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaCeiling>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaCeiling>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.AlphaCeiling();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? AlphaFloor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaFloor>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaFloor>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.AlphaFloor();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.AlphaInverse? AlphaInverse
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.AlphaModulationEffect? AlphaModulationEffect
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.AlphaModulationFixed? AlphaModulationFixed
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.AlphaReplace? AlphaReplace
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.BiLevel? BiLevel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Blur? Blur
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.ColorChange? ColorChange
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.ColorReplacement? ColorReplacement
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Duotone? Duotone
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.FillOverlay? FillOverlay
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Boolean? Grayscale
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Grayscale>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Grayscale>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Grayscale();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Hsl? Hsl
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.LuminanceEffect? LuminanceEffect
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.TintEffect? TintEffect
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.BlipExtensionList? BlipExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
