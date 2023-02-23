using DocumentFormat.OpenXml.Packaging;

using DocxDocument.Model;

using System.Linq;
using DocumentFormat.OpenXml.VariantTypes;
using OP = DocumentFormat.OpenXml;
using DM = DocxDocument.Model;
using System.Collections.Generic;
using EP = DocumentFormat.OpenXml.ExtendedProperties;
using CP = DocumentFormat.OpenXml.CustomProperties;
using VT = DocumentFormat.OpenXml.VariantTypes;
using WP = DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using System.Globalization;
using System.Collections;
using System.Reflection;

namespace DocxDocument.Reader;

public partial class DocxWriter
{
  public void WriteDocumentProperties(DocumentProperties dmProperties)
  {
    WritePackageProperties(dmProperties);
    WriteExtendedProperties(dmProperties);
    WriteCustomProperties(dmProperties);
    WriteDocumentSettings(dmProperties);
  }

  private void WritePackageProperties(DocumentProperties dmDocumentProperties)
  {
    var coreFilePropertiesPart = WordprocessingDocument.CoreFilePropertiesPart;
    if (coreFilePropertiesPart == null)
    {
      coreFilePropertiesPart = WordprocessingDocument.AddCoreFilePropertiesPart();
    }

    var coreFileProperties = WordprocessingDocument.PackageProperties;

    coreFileProperties.Identifier = dmDocumentProperties.Identifier;
    coreFileProperties.Title = dmDocumentProperties.Title;
    coreFileProperties.Version = dmDocumentProperties.Version;
    coreFileProperties.Revision = dmDocumentProperties.Revision;
    coreFileProperties.Category = dmDocumentProperties.Category;
    coreFileProperties.Subject = dmDocumentProperties.Subject;
    coreFileProperties.Description = dmDocumentProperties.Description;
    coreFileProperties.Keywords = dmDocumentProperties.Keywords;
    coreFileProperties.Language = dmDocumentProperties.Language;
    coreFileProperties.ContentStatus = dmDocumentProperties.ContentStatus;
    coreFileProperties.ContentType = dmDocumentProperties.ContentType;

    coreFileProperties.Created = dmDocumentProperties.Created;
    coreFileProperties.Creator = dmDocumentProperties.Creator;
    coreFileProperties.Modified = dmDocumentProperties.LastModified;
    coreFileProperties.LastModifiedBy = dmDocumentProperties.LastModifiedBy;
    coreFileProperties.LastPrinted = dmDocumentProperties.LastPrinted;
  }

  private void WriteExtendedProperties(DocumentProperties dmDocumentProperties)
  {
    var extendedFilePropertiesPart = WordprocessingDocument.ExtendedFilePropertiesPart;
    if (extendedFilePropertiesPart == null)
    {
      extendedFilePropertiesPart = WordprocessingDocument.AddExtendedFilePropertiesPart();
    }

    var extFileProperties = extendedFilePropertiesPart.RootElement as EP.Properties;
    if (extFileProperties is null)
    {
      extFileProperties = new EP.Properties();
      extendedFilePropertiesPart.Properties = extFileProperties;
    }

    extFileProperties.Application = CreateStringProperty<EP.Application>(dmDocumentProperties.Application);
    extFileProperties.ApplicationVersion = CreateStringProperty<EP.ApplicationVersion>(dmDocumentProperties.ApplicationVersion);
    extFileProperties.Template = CreateStringProperty<EP.Template>(dmDocumentProperties.Template);

    extFileProperties.Company = CreateStringProperty<EP.Company>(dmDocumentProperties.Company);
    extFileProperties.Manager = CreateStringProperty<EP.Manager>(dmDocumentProperties.Manager);

    extFileProperties.DigitalSignature = CreateDigitalSignatureProperty(dmDocumentProperties.DigitalSignature);

    extFileProperties.DocumentSecurity = new EP.DocumentSecurity(dmDocumentProperties.DocumentSecurity.ToString());
    extFileProperties.SharedDocument = CreateBooleanProperty<EP.SharedDocument>(dmDocumentProperties.SharedDocument);
    extFileProperties.ScaleCrop = CreateBooleanProperty<EP.ScaleCrop>(dmDocumentProperties.ScaleCrop);
    extFileProperties.LinksUpToDate = CreateBooleanProperty<EP.LinksUpToDate>(dmDocumentProperties.LinksUpToDate);
    extFileProperties.HyperlinksChanged = CreateBooleanProperty<EP.HyperlinksChanged>(dmDocumentProperties.HyperlinksChanged);
    extFileProperties.HyperlinkBase = CreateStringProperty<EP.HyperlinkBase>(dmDocumentProperties.HyperlinkBase);

    extFileProperties.TotalTime = CreateIntProperty<EP.TotalTime>(dmDocumentProperties.TotalTime);
    extFileProperties.Pages = CreateIntProperty<EP.Pages>(dmDocumentProperties.Pages);
    extFileProperties.Words = CreateIntProperty<EP.Words>(dmDocumentProperties.Words);
    extFileProperties.CharactersWithSpaces = CreateIntProperty<EP.CharactersWithSpaces>(dmDocumentProperties.CharactersWithSpaces);
    extFileProperties.Characters = CreateIntProperty<EP.Characters>(dmDocumentProperties.Characters);
    extFileProperties.Lines = CreateIntProperty<EP.Lines>(dmDocumentProperties.Lines);
    extFileProperties.Paragraphs = CreateIntProperty<EP.Paragraphs>(dmDocumentProperties.Paragraphs);

    if (dmDocumentProperties.HeadingPairs != null)
    {
      extFileProperties.HeadingPairs = new EP.HeadingPairs();
      var children = new List<OP.OpenXmlElement>();

      foreach (var headingPair in dmDocumentProperties.HeadingPairs)
      {
        children.Add(new VT.Variant(new VTLPSTR(headingPair.Name)));
        children.Add(new VT.Variant(new VTInt32(headingPair.Count.ToString())));
      }
      extFileProperties.HeadingPairs.AddChild(new VTVector(children) { Size = (uint)children.Count, BaseType = VectorBaseValues.Variant });
    }
    else
    {
      dmDocumentProperties.HeadingPairs = null;
    }

    if (dmDocumentProperties.TitlesOfParts != null)
    {
      extFileProperties.TitlesOfParts = new EP.TitlesOfParts();
      var children = new List<OP.OpenXmlElement>();

      foreach (var title in dmDocumentProperties.TitlesOfParts)
      {
        children.Add(new VTLPSTR(title));
      }
      extFileProperties.TitlesOfParts.AddChild(new VTVector(children) { Size = (uint)children.Count, BaseType = VectorBaseValues.Lpstr });
    }
    else
    {
      dmDocumentProperties.TitlesOfParts = null;
    }

    if (dmDocumentProperties.HyperlinkList != null)
    {
      extFileProperties.HyperlinkList = new EP.HyperlinkList();
      var children = new List<OP.OpenXmlElement>();

      foreach (var hyperlinkData in dmDocumentProperties.HyperlinkList)
      {
        children.Add(new VT.Variant(new VTInt32(hyperlinkData.Data1.ToString())));
        children.Add(new VT.Variant(new VTInt32(hyperlinkData.Data2.ToString())));
        children.Add(new VT.Variant(new VTInt32(hyperlinkData.Data3.ToString())));
        children.Add(new VT.Variant(new VTInt32(hyperlinkData.Data4.ToString())));
        children.Add(new VT.Variant(new VTLPSTR(hyperlinkData.Target)));
        children.Add(new VT.Variant(new VTLPSTR(hyperlinkData.Location)));
      }
      extFileProperties.HyperlinkList.AddChild(new VTVector(children) { Size = (uint)children.Count, BaseType = VectorBaseValues.Variant });
    }
    else
    {
      dmDocumentProperties.HyperlinkList = null;
    }

  }

  private void WriteCustomProperties(DocumentProperties dmDocumentProperties)
  {
    var customFilePropertiesPart = WordprocessingDocument.CustomFilePropertiesPart;
    if (customFilePropertiesPart == null)
    {
      customFilePropertiesPart = WordprocessingDocument.AddCustomFilePropertiesPart();
    }

    var customFileProperties = customFilePropertiesPart.RootElement as CP.Properties;
    if (customFileProperties is null)
    {
      customFileProperties = new CP.Properties();
      customFilePropertiesPart.Properties = customFileProperties;
    }


    foreach (var dmProperty in dmDocumentProperties.OfType<CustomDocumentProperty>())
    {
      if (dmProperty.FormatId == null)
        dmProperty.FormatId = new Guid("{D5CDD505-2E9C-101B-9397-08002B2CF9AE}");
      if (dmProperty.PropertyId == null)
        dmProperty.PropertyId = 2;
      var cpProperty = new CP.CustomDocumentProperty
      {
        PropertyId = dmProperty.PropertyId,
        Name = dmProperty.Name,
      };
      if (dmProperty.FormatId != null)
        cpProperty.FormatId = ((Guid)dmProperty.FormatId).ToString("B").ToUpperInvariant();
      if (dmProperty.LinkTarget != null)
        cpProperty.LinkTarget = dmProperty.LinkTarget;
      if (dmProperty.Value != null)
        cpProperty.AddChild(CreateVariant((DM.Variant)dmProperty.Value));
      customFileProperties.AddChild(cpProperty);
    }
  }

  private void WriteDocumentSettings(DocumentProperties dmDocumentProperties)
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();
    var docSettingsPart = mainDocumentPart.DocumentSettingsPart;
    if (docSettingsPart == null)
    {
      docSettingsPart = mainDocumentPart.AddNewPart<DocumentSettingsPart>();
    }

    var wpSettings = docSettingsPart.RootElement as WP.Settings;
    if (wpSettings is null)
    {
      wpSettings = new WP.Settings();
      docSettingsPart.Settings = wpSettings;
    }

    if (dmDocumentProperties.DocumentId != null)
    {
      var wpDocumentId = wpSettings.Elements<DocumentFormat.OpenXml.Office2010.Word.DocumentId>().FirstOrDefault();
      if (wpDocumentId!=null)
        wpDocumentId.Val = ((int)dmDocumentProperties.DocumentId).ToString("X8");
      else
        wpSettings.AddChild(new DocumentFormat.OpenXml.Office2010.Word.DocumentId { Val = ((int)dmDocumentProperties.DocumentId).ToString("X8") });
    }
    if (dmDocumentProperties.PersistentDocumentId != null)
    {
      var wpDocumentId = wpSettings.Elements<DocumentFormat.OpenXml.Office2013.Word.PersistentDocumentId>().FirstOrDefault();
      if (wpDocumentId != null)
        wpDocumentId.Val = ((Guid)dmDocumentProperties.PersistentDocumentId).ToString("B").ToUpperInvariant();
      else
        wpSettings.AddChild(new DocumentFormat.OpenXml.Office2013.Word.PersistentDocumentId 
          { Val = ((Guid)dmDocumentProperties.PersistentDocumentId).ToString("B").ToUpperInvariant() });
    }
  }

  private static PropertyType? CreateStringProperty<PropertyType>(string? value) where PropertyType : OpenXmlLeafTextElement, new()
  {
    if (value == null)
      return null;
    var result = new PropertyType { Text = value };
    return result;
  }

  private static PropertyType? CreateBooleanProperty<PropertyType>(bool? value) where PropertyType : OpenXmlLeafTextElement, new()
  {
    var result = new PropertyType { Text = value.ToString().ToLower() };
    return result;
  }

  private static PropertyType? CreateIntProperty<PropertyType>(int? value) where PropertyType : OpenXmlLeafTextElement, new()
  {
    var result = new PropertyType { Text = value.ToString() };
    return result;
  }

  private static EP.DigitalSignature? CreateDigitalSignatureProperty(byte[]? value)
  {
    if (value == null)
      return null;
    var result = new EP.DigitalSignature(CreateBlob(value));
    return result;
  }

  private static VTBlob? CreateBlob(byte[]? value)
  {
    if (value == null)
      return null;
    var newData = new byte[value.Length + 4];
    var countBytes = BitConverter.GetBytes(value.Length);
    countBytes.CopyTo(newData, 0);
    value.CopyTo(newData, 4);
    return new VTBlob(Convert.ToBase64String(newData));
  }

  private static VTOBlob? CreateOBlob(byte[]? value)
  {
    if (value == null)
      return null;
    var newData = new byte[value.Length + 4];
    var countBytes = BitConverter.GetBytes(value.Length);
    countBytes.CopyTo(newData, 0);
    value.CopyTo(newData, 4);
    return new VTOBlob(Convert.ToBase64String(newData));
  }

  private static VTStorage? CreateStorage(byte[]? value)
  {
    if (value == null)
      return null;
    var result = new VTStorage();
    result.Text = Convert.ToBase64String(value);
    return result;
  }

  private static VTOStorage? CreateOStorage(byte[]? value)
  {
    if (value == null)
      return null;
    var result = new VTOStorage();
    result.Text = Convert.ToBase64String(value);
    return result;
  }

  private static VTStreamData? CreateStreamData(byte[]? value)
  {
    if (value == null)
      return null;
    var result = new VTStreamData();
    result.Text = Convert.ToBase64String(value);
    return result;
  }

  private static VTOStreamData? CreateOStreamData(GuidDataPair? value)
  {
    if (value == null)
      return null;
    var result = new VTOStreamData();
    result.Text = Convert.ToBase64String(value.Data);
    return result;
  }

  private static VTVStreamData? CreateVStreamData(GuidDataPair? value)
  {
    if (value == null)
      return null;
    var result = new VTVStreamData();
    result.Text = Convert.ToBase64String(value.Data);
    if (value.Guid != null)
      result.Version = ((Guid)value.Guid).ToString("B").ToUpperInvariant();
    return result;
  }

  private static (string lower, string upper) CreateVTArrayBounds(System.Array array)
  {
    var n = array.Rank;
    var lBounds = new List<string>();
    var uBounds = new List<string>();
    for (int i = 0; i < n; i++)
    {
      var lBound = array.GetLowerBound(i);
      var uBound = array.GetUpperBound(i);
      lBounds.Add(lBound.ToString());
      uBounds.Add(uBound.ToString());
    }

    return (string.Join(",", lBounds), string.Join(",", uBounds));
  }

  private static VTArray CreateVTArray(System.Array value)
  {
    if (value == null || value.Length==0)
      return null;
    var firstItem = value.GetValue(0);
    var type = firstItem.GetType();
    if (!DM.VariantTypeMapping.TypeToArrayBaseType.TryGetValue(type, out var baseType))
      throw new InvalidDataException($"Unknown VTArray base type");

    if (value.Rank>1)
      throw new InvalidDataException($"Multidimension VTArray cannot be created in this implementation");
    //var bounds = CreateVTArrayBounds(value);
    var result = new VTArray
    {
      BaseType = baseType,
      LowerBounds = new Int32Value(value.GetLowerBound(0)),
      UpperBounds = new Int32Value(value.GetUpperBound(0))
    };
    var format = typeof(ArrayBaseValues).GetField(baseType.ToString()).GetCustomAttributes<EnumStringAttribute>()
      .FirstOrDefault()?.Value;
    for (int i = 0; i < value.Length; i++)
    {
      var item = value.GetValue(i);
      result.AddChild(CreateVariant(item, format));
    }
    return result;
  }

  private static VTVector CreateVTVector(IEnumerable value)
  {
    if (value == null)
      return null;
    var typedValue = value.OfType<object>();
    var firstItem = typedValue.FirstOrDefault();
    if (firstItem == null)
      return null;
    var type = firstItem.GetType();
    if (!DM.VariantTypeMapping.TypeToVectorBaseType.TryGetValue(type, out var baseType))
      throw new InvalidDataException($"Unknown VTArray base type");
    var result = new VTVector
    {
      BaseType = baseType,
      Size = (uint)typedValue.Count(),
    };
    var format = typeof(VectorBaseValues).GetField(baseType.ToString()).GetCustomAttributes<EnumStringAttribute>()
      .FirstOrDefault()?.Value;
    foreach (var item in typedValue)
    {
      result.AddChild(CreateVariant(item, format));
    }
    return result;
  }
  private static OpenXmlElement CreateVariant(DM.Variant value)
  {
    if (value.Type == DM.VariantType.Variant)
      return new VT.Variant { InnerVariant = (VT.Variant)CreateVariant((DM.Variant)value.Value) };
    if (value.Type == DM.VariantType.Bool)
      return new VTBool(((bool)value.Value).ToString().ToLowerInvariant());
    if (value.Type == DM.VariantType.String)
      return new VTLPSTR(value.Value.ToString());
    if (value.Type == DM.VariantType.Int32)
      return new VTInt32(((Int32)value.Value).ToString());
    if (value.Type == DM.VariantType.Int64)
      return new VTInt64(((Int64)value.Value).ToString());
    if (value.Type == DM.VariantType.UInt32)
      return new VTUnsignedInt32(((UInt32)value.Value).ToString());
    if (value.Type == DM.VariantType.UInt64)
      return new VTUnsignedInt64(((UInt64)value.Value).ToString());
    if (value.Type == DM.VariantType.Int8)
      return new VTByte(((SByte)value.Value).ToString());
    if (value.Type == DM.VariantType.UInt8)
      return new VTUnsignedByte(((byte)value.Value).ToString());
    if (value.Type == DM.VariantType.Int16)
      return new VTShort(((Int16)value.Value).ToString());
    if (value.Type == DM.VariantType.UInt16)
      return new VTShort(((UInt16)value.Value).ToString());
    if (value.Type == DM.VariantType.DateTime)
      return new VTFileTime(((DateTime)value.Value).ToUniversalTime().ToString("s")+"Z");
    if (value.Type == DM.VariantType.Float)
      return new VTFloat(((float)value.Value).ToString(CultureInfo.InvariantCulture));
    if (value.Type == DM.VariantType.Double)
      return new VTDouble(((double)value.Value).ToString(CultureInfo.InvariantCulture));
    if (value.Type == DM.VariantType.Currency)
      return new VTDecimal(((decimal)value.Value).ToString("F",CultureInfo.InvariantCulture));
    if (value.Type == DM.VariantType.Decimal)
      return new VTDecimal(((decimal)value.Value).ToString(CultureInfo.InvariantCulture));
    if (value.Type == DM.VariantType.Null)
      return new VT.VTNull();
    if (value.Type == DM.VariantType.Empty)
      return new VT.VTEmpty();
    if (value.Type == DM.VariantType.Error)
      return new VTError(((Int32)value.Value).ToString("X8"));
    if (value.Type == DM.VariantType.ClassId)
      return new VT.VTClassId(((Guid)value.Value).ToString("B").ToUpperInvariant());


    if (value.Type == DM.VariantType.Blob)
      return CreateBlob((byte[])value.Value);
    if (value.Type == DM.VariantType.OBlob)
      return CreateOBlob((byte[])value.Value);
    if (value.Type == DM.VariantType.Storage)
      return CreateStorage(value.Value as byte[]);
    if (value.Type == DM.VariantType.OStorage)
      return CreateOStorage(value.Value as byte[]);
    if (value.Type == DM.VariantType.StreamData)
      return CreateStreamData(value.Value as byte[]);
    if (value.Type == DM.VariantType.OStreamData)
      return CreateOStreamData(value.Value as GuidDataPair);
    if (value.Type == DM.VariantType.VStreamData)
      return CreateVStreamData(value.Value as GuidDataPair);

    
    if (value.Type == DM.VariantType.Array)
      return CreateVTArray(value.Value as System.Array);
    if (value.Type == DM.VariantType.Vector)
      return CreateVTVector(value.Value as IEnumerable);

    throw new InvalidDataException($"Default of type {value.Type} cannot be converted to VTVariantType");
  }

  private static OpenXmlElement CreateVariant(object value, string format)
  {
    if (format=="error")
      return new VTError(((Int32)value).ToString("X8"));
    if (format == "cy")
      return new VTCurrency(((decimal)value).ToString("F", CultureInfo.InvariantCulture));

    if (value is DM.Variant variant)
      return new VT.Variant { InnerVariant = (VT.Variant)CreateVariant(variant) };
    if (value is bool boolValue)
      return new VTBool(boolValue.ToString().ToLowerInvariant());
    if (value is string str)
      return new VTLPSTR(str);
    if (value is Int32 int32value)
      return new VTInt32(int32value.ToString());
    if (value is Int64 int64value)
      return new VTInt64(int64value.ToString());
    if (value is UInt32 uint32value)
      return new VTUnsignedInt32(uint32value.ToString());
    if (value is UInt64 uint64value)
      return new VTUnsignedInt64(uint64value.ToString());
    if (value is SByte int8value)
      return new VTByte(int8value.ToString());
    if (value is byte uint8value)
      return new VTUnsignedByte(uint8value.ToString());
    if (value is Int16 int16value)
      return new VTShort(int16value.ToString());
    if (value is UInt16 uint16value)
      return new VTShort(uint16value.ToString());
    if (value is DateTime datetimeValue)
      return new VTFileTime(datetimeValue.ToUniversalTime().ToString("s") + "Z");
    if (value is float floatValue)
      return new VTFloat(floatValue.ToString(CultureInfo.InvariantCulture));
    if (value is double doubleValue)
      return new VTDouble(doubleValue.ToString(CultureInfo.InvariantCulture));
    if (value is decimal decimalValue)
      return new VTDecimal(decimalValue.ToString(CultureInfo.InvariantCulture));
    if (value == null)
      return new VT.VTNull();
    if (value is Guid guidValue)
      return new VT.VTClassId(guidValue.ToString("B").ToUpperInvariant());

    throw new InvalidDataException($"Default of type {value.GetType()} cannot be converted to VTVariantType");
  }

}