namespace DocumentModel.Drawings;

/// <summary>
/// Space After.
/// </summary>
public class SpaceAfterImpl: DocumentModel.Drawings.TextSpacingTypeImpl, SpaceAfter
{
  public new DocumentFormat.OpenXml.Drawing.SpaceAfter? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.SpaceAfter?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override Int32? SpacingPercent
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpacingPercent>();
        return (Int32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpacingPercent>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.Int32?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.SpacingPercent{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public override Int32? SpacingPoints
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpacingPoints>();
        return (Int32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpacingPoints>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.Int32?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.SpacingPoints{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
