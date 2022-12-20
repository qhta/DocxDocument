namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocEvents Class.
/// </summary>
public partial class DocEventsImpl: ModelElementImpl, DocEvents
{
  public DocumentFormat.OpenXml.Office.Word.DocEvents? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.DocEvents?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DocEventsImpl(): base() {}
  
  public DocEventsImpl(DocumentFormat.OpenXml.Office.Word.DocEvents openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// EventDocNewXsdString.
  /// </summary>
  public String? EventDocNewXsdString
  {
    get => (System.String?)OpenXmlElement?.EventDocNewXsdString?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EventDocNewXsdString != null)
        {
          if (value is not null)
            OpenXmlElement.EventDocNewXsdString.Text = value;
          else
            OpenXmlElement.EventDocNewXsdString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EventDocNewXsdString = new DocumentFormat.OpenXml.Office.Word.EventDocNewXsdString{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// EventDocOpenXsdString.
  /// </summary>
  public String? EventDocOpenXsdString
  {
    get => (System.String?)OpenXmlElement?.EventDocOpenXsdString?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EventDocOpenXsdString != null)
        {
          if (value is not null)
            OpenXmlElement.EventDocOpenXsdString.Text = value;
          else
            OpenXmlElement.EventDocOpenXsdString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EventDocOpenXsdString = new DocumentFormat.OpenXml.Office.Word.EventDocOpenXsdString{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// EventDocCloseXsdString.
  /// </summary>
  public String? EventDocCloseXsdString
  {
    get => (System.String?)OpenXmlElement?.EventDocCloseXsdString?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EventDocCloseXsdString != null)
        {
          if (value is not null)
            OpenXmlElement.EventDocCloseXsdString.Text = value;
          else
            OpenXmlElement.EventDocCloseXsdString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EventDocCloseXsdString = new DocumentFormat.OpenXml.Office.Word.EventDocCloseXsdString{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// EventDocSyncXsdString.
  /// </summary>
  public String? EventDocSyncXsdString
  {
    get => (System.String?)OpenXmlElement?.EventDocSyncXsdString?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EventDocSyncXsdString != null)
        {
          if (value is not null)
            OpenXmlElement.EventDocSyncXsdString.Text = value;
          else
            OpenXmlElement.EventDocSyncXsdString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EventDocSyncXsdString = new DocumentFormat.OpenXml.Office.Word.EventDocSyncXsdString{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// EventDocXmlAfterInsertXsdString.
  /// </summary>
  public String? EventDocXmlAfterInsertXsdString
  {
    get => (System.String?)OpenXmlElement?.EventDocXmlAfterInsertXsdString?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EventDocXmlAfterInsertXsdString != null)
        {
          if (value is not null)
            OpenXmlElement.EventDocXmlAfterInsertXsdString.Text = value;
          else
            OpenXmlElement.EventDocXmlAfterInsertXsdString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EventDocXmlAfterInsertXsdString = new DocumentFormat.OpenXml.Office.Word.EventDocXmlAfterInsertXsdString{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// EventDocXmlBeforeDeleteXsdString.
  /// </summary>
  public String? EventDocXmlBeforeDeleteXsdString
  {
    get => (System.String?)OpenXmlElement?.EventDocXmlBeforeDeleteXsdString?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EventDocXmlBeforeDeleteXsdString != null)
        {
          if (value is not null)
            OpenXmlElement.EventDocXmlBeforeDeleteXsdString.Text = value;
          else
            OpenXmlElement.EventDocXmlBeforeDeleteXsdString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EventDocXmlBeforeDeleteXsdString = new DocumentFormat.OpenXml.Office.Word.EventDocXmlBeforeDeleteXsdString{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// EventDocContentControlAfterInsertXsdString.
  /// </summary>
  public String? EventDocContentControlAfterInsertXsdString
  {
    get => (System.String?)OpenXmlElement?.EventDocContentControlAfterInsertXsdString?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EventDocContentControlAfterInsertXsdString != null)
        {
          if (value is not null)
            OpenXmlElement.EventDocContentControlAfterInsertXsdString.Text = value;
          else
            OpenXmlElement.EventDocContentControlAfterInsertXsdString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EventDocContentControlAfterInsertXsdString = new DocumentFormat.OpenXml.Office.Word.EventDocContentControlAfterInsertXsdString{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// EventDocContentControlBeforeDeleteXsdString.
  /// </summary>
  public String? EventDocContentControlBeforeDeleteXsdString
  {
    get => (System.String?)OpenXmlElement?.EventDocContentControlBeforeDeleteXsdString?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EventDocContentControlBeforeDeleteXsdString != null)
        {
          if (value is not null)
            OpenXmlElement.EventDocContentControlBeforeDeleteXsdString.Text = value;
          else
            OpenXmlElement.EventDocContentControlBeforeDeleteXsdString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EventDocContentControlBeforeDeleteXsdString = new DocumentFormat.OpenXml.Office.Word.EventDocContentControlBeforeDeleteXsdString{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// EventDocContentControlOnExistXsdString.
  /// </summary>
  public String? EventDocContentControlOnExistXsdString
  {
    get => (System.String?)OpenXmlElement?.EventDocContentControlOnExistXsdString?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EventDocContentControlOnExistXsdString != null)
        {
          if (value is not null)
            OpenXmlElement.EventDocContentControlOnExistXsdString.Text = value;
          else
            OpenXmlElement.EventDocContentControlOnExistXsdString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EventDocContentControlOnExistXsdString = new DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnExistXsdString{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// EventDocContentControlOnEnterXsdString.
  /// </summary>
  public String? EventDocContentControlOnEnterXsdString
  {
    get => (System.String?)OpenXmlElement?.EventDocContentControlOnEnterXsdString?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EventDocContentControlOnEnterXsdString != null)
        {
          if (value is not null)
            OpenXmlElement.EventDocContentControlOnEnterXsdString.Text = value;
          else
            OpenXmlElement.EventDocContentControlOnEnterXsdString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EventDocContentControlOnEnterXsdString = new DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnEnterXsdString{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// EventDocStoreUpdateXsdString.
  /// </summary>
  public String? EventDocStoreUpdateXsdString
  {
    get => (System.String?)OpenXmlElement?.EventDocStoreUpdateXsdString?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EventDocStoreUpdateXsdString != null)
        {
          if (value is not null)
            OpenXmlElement.EventDocStoreUpdateXsdString.Text = value;
          else
            OpenXmlElement.EventDocStoreUpdateXsdString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EventDocStoreUpdateXsdString = new DocumentFormat.OpenXml.Office.Word.EventDocStoreUpdateXsdString{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// EventDocContentControlUpdateXsdString.
  /// </summary>
  public String? EventDocContentControlUpdateXsdString
  {
    get => (System.String?)OpenXmlElement?.EventDocContentControlUpdateXsdString?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EventDocContentControlUpdateXsdString != null)
        {
          if (value is not null)
            OpenXmlElement.EventDocContentControlUpdateXsdString.Text = value;
          else
            OpenXmlElement.EventDocContentControlUpdateXsdString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EventDocContentControlUpdateXsdString = new DocumentFormat.OpenXml.Office.Word.EventDocContentControlUpdateXsdString{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// EventDocBuildingBlockAfterInsertXsdString.
  /// </summary>
  public String? EventDocBuildingBlockAfterInsertXsdString
  {
    get => (System.String?)OpenXmlElement?.EventDocBuildingBlockAfterInsertXsdString?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EventDocBuildingBlockAfterInsertXsdString != null)
        {
          if (value is not null)
            OpenXmlElement.EventDocBuildingBlockAfterInsertXsdString.Text = value;
          else
            OpenXmlElement.EventDocBuildingBlockAfterInsertXsdString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EventDocBuildingBlockAfterInsertXsdString = new DocumentFormat.OpenXml.Office.Word.EventDocBuildingBlockAfterInsertXsdString{ Text = value };
        }
      }
    }
  }
  
}
