namespace DocumentModel.Properties;

/// <summary>
/// Custom File Property.
/// </summary>
public partial class CustomDocumentPropertyImpl: ModelElementImpl, CustomDocumentProperty
{
  public DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomDocumentPropertyImpl(): base() {}
  
  public CustomDocumentPropertyImpl(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Format ID
  /// </summary>
  public String? FormatId
  {
    get => (System.String?)OpenXmlElement?.FormatId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FormatId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Property ID
  /// </summary>
  public Int32? PropertyId
  {
    get => (System.Int32?)OpenXmlElement?.PropertyId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PropertyId = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Custom File Property Name
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Bookmark Link Target
  /// </summary>
  public String? LinkTarget
  {
    get => (System.String?)OpenXmlElement?.LinkTarget?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LinkTarget = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Vector.
  /// </summary>
  public DocumentModel.VariantTypes.VTVector? VTVector
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTVector>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTVectorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTVector>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTVectorImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Array.
  /// </summary>
  public DocumentModel.VariantTypes.VTArray? VTArray
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTArray>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTArrayImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTArray>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTArrayImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Binary Blob.
  /// </summary>
  public DocumentModel.VariantTypes.VTBlob? VTBlob
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTBlob>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTBlobImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTBlob>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTBlobImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Binary Blob Object.
  /// </summary>
  public DocumentModel.VariantTypes.VTBlob? VTOBlob
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTOBlob>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTBlobImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTOBlob>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTBlobImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Empty.
  /// </summary>
  public DocumentModel.VariantTypes.VTEmpty? VTEmpty
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTEmpty>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTEmptyImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTEmpty>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTEmptyImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Null.
  /// </summary>
  public DocumentModel.VariantTypes.VTNull? VTNull
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTNull>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTNullImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTNull>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTNullImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// 1-Byte Signed Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTSignedByte? VTByte
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTByte>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTSignedByteImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTByte>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTSignedByteImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// 2-Byte Signed Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTShort? VTShort
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTShort>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTShortImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTShort>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTShortImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// 4-Byte Signed Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTInt32? VTInt32
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTInt32>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTInt32Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTInt32>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTInt32Impl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// 8-Byte Signed Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTInt64? VTInt64
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTInt64>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTInt64Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTInt64>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTInt64Impl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTInt64? VTInteger
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTInteger>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTInt64Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTInteger>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTInt64Impl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// 1-Byte Unsigned Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTByte? VTUnsignedByte
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTByteImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTByteImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// 2-Byte Unsigned Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTUnsignedShort? VTUnsignedShort
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTUnsignedShortImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTUnsignedShortImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// 4-Byte Unsigned Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTUnsignedInt32? VTUnsignedInt32
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTUnsignedInt32Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTUnsignedInt32Impl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// 8-Byte Unsigned Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTUnsignedInt64? VTUnsignedInt64
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTUnsignedInt64Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTUnsignedInt64Impl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Unsigned Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTUnsignedInt64? VTUnsignedInteger
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTUnsignedInt64Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTUnsignedInt64Impl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// 4-Byte Real Number.
  /// </summary>
  public DocumentModel.VariantTypes.VTFloat? VTFloat
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTFloat>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTFloatImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTFloat>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTFloatImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// 8-Byte Real Number.
  /// </summary>
  public DocumentModel.VariantTypes.VTDouble? VTDouble
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTDouble>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTDoubleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTDouble>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTDoubleImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Decimal.
  /// </summary>
  public DocumentModel.VariantTypes.VTDecimal? VTDecimal
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTDecimal>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTDecimalImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTDecimal>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTDecimalImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// LPSTR.
  /// </summary>
  public DocumentModel.VariantTypes.VTString? VTLPSTR
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTLPSTR>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTStringImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTLPSTR>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTStringImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// LPWSTR.
  /// </summary>
  public DocumentModel.VariantTypes.VTString? VTLPWSTR
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTLPWSTR>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTStringImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTLPWSTR>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTStringImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Basic String.
  /// </summary>
  public DocumentModel.VariantTypes.VTString? VTBString
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTBString>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTStringImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTBString>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTStringImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Date and Time.
  /// </summary>
  public DocumentModel.VariantTypes.VTDate? VTDate
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTDate>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTDateImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTDate>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTDateImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// File Time.
  /// </summary>
  public DocumentModel.VariantTypes.VTDateTime? VTFileTime
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTFileTime>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTDateTimeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTFileTime>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTDateTimeImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Boolean.
  /// </summary>
  public String? VTBool
  {
    get => (System.String?)OpenXmlElement?.VTBool?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.VTBool != null)
        {
          if (value is not null)
            OpenXmlElement.VTBool.Text = value;
          else
            OpenXmlElement.VTBool = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.VTBool = new DocumentFormat.OpenXml.VariantTypes.VTBool{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Currency.
  /// </summary>
  public DocumentModel.VariantTypes.VTCurrency? VTCurrency
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTCurrency>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTCurrencyImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTCurrency>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTCurrencyImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Error Status Code.
  /// </summary>
  public DocumentModel.VariantTypes.VTError? VTError
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTError>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTErrorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTError>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTErrorImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Binary Stream.
  /// </summary>
  public DocumentModel.VariantTypes.VTStream? VTStreamData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTStreamData>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTStreamImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTStreamData>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTStreamImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Binary Stream Object.
  /// </summary>
  public DocumentModel.VariantTypes.VTStream? VTOStreamData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTOStreamData>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTStreamImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTOStreamData>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTStreamImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Binary Storage.
  /// </summary>
  public DocumentModel.VariantTypes.VTStorage? VTStorage
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTStorage>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTStorageImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTStorage>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTStorageImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Binary Storage Object.
  /// </summary>
  public DocumentModel.VariantTypes.VTStorage? VTOStorage
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTOStorage>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTStorageImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTOStorage>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTStorageImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Binary Versioned Stream.
  /// </summary>
  public DocumentModel.VariantTypes.VTVStream? VTVStreamData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTVStreamData>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTVStreamImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTVStreamData>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTVStreamImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Class ID.
  /// </summary>
  public DocumentModel.VariantTypes.VTClassId? VTClassId
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTClassId>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTClassIdImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTClassId>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTClassIdImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  /// <summary>
  /// Clipboard Data.
  /// </summary>
  public DocumentModel.VariantTypes.VTClipboardData? VTClipboardData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTClipboardData>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTClipboardDataImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTClipboardData>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTClipboardDataImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
}
