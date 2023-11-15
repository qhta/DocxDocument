using DocumentModel;

using Qhta.TypeUtils;

namespace DocxDocument.Test;

public class ReadWriteTest : ReadTest
{
  public Qhta.Xml.Serialization.QXmlSerializer ModelSerializer =
    new(typeof(DocumentModel.Document), typeof(DocumentModel.Document).Assembly.GetExportedTypes(),
      new SerializationOptions { AcceptAllProperties = false, AcceptDataMembers = true });

  public bool TestCreate()
  {
    if (!TestCreateInFile()) return false;
    if (!TestCreateInMemory()) return false;
    //if (!TestCreateInMemoryAndSaveAsFlatOpc()) return false;
    return true;
  }

  public bool TestCreateInFile()
  {
    bool success = false;
    var samplesPath = SamplesPath;
    var fileName = Path.Combine(samplesPath, "TestCreate.docx");
    Output.WriteLine($"TestCreateInFile: {fileName}");
    try
    {
      using (var document = DM.Document.Create(fileName))
      {
        Output.WriteLine($"  Type: {document.DocumentType}");
        if (success)
          Debug.Assert(document.DocumentType == DX.WordprocessingDocumentType.Document);
      }
      success = true;
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
    }
    if (success)
    {
      success = TestReadProperties(fileName);
      if (success)
        Output.WriteLine($"Test passed");
    }
    return success;
  }

  public bool TestCreateInMemory()
  {
    bool success = false;
    var samplesPath = SamplesPath;
    var fileName = Path.Combine(samplesPath, "TestCreateInMemory.docx");
    Output.WriteLine($"TestCreateInMemory");
    try
    {
      using (var document = new DM.Document())
      {
        Output.WriteLine($"  Type: {document.DocumentType}");
        Debug.Assert(document.DocumentType == DX.WordprocessingDocumentType.Document);
        document.SaveAs(fileName);
      }
      success = true;
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
    }
    if (success)
    {
      success = TestReadProperties(fileName);
      if (success)
        Output.WriteLine($"Test passed");
    }
    return success;
  }

  public bool TestCreateInMemoryAndSaveAsFlatOpc()
  {
    bool success = false;
    var samplesPath = SamplesPath;
    var fileName = Path.Combine(samplesPath, "TestCreateInMemory.flat.xml");
    Output.WriteLine($"TestCreateInMemoryAndSaveAsFlatOpc");
    try
    {
      using (var document = new DM.Document())
      {
        Output.WriteLine($"  Type: {document.DocumentType}");
        Debug.Assert(document.DocumentType == DX.WordprocessingDocumentType.Document);
        document.SaveAsFlatOpc(fileName);
      }
      success = true;
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
    }
    if (success)
    {
      success = TestReadProperties(fileName);
      if (success)
        Output.WriteLine($"Test passed");
    }
    return success;
  }

  public bool TestCopyPropertiesOne()
  {
    var samplesPath = SamplesPath;
    var file = Path.Combine(samplesPath, "DocumentProperties.docx");
    return TestCopyProperties(file);
  }

  public bool TestCopyProperties(string fileName)
  {
    bool success = false;
    var sourceFile = fileName;
    var targetFile = Path.ChangeExtension(sourceFile, ".new.docx");
    Output.WriteLine($"TestCopyProperties: {sourceFile} -> {targetFile}");
    try
    {
      using (var sourceDocument = DM.Document.Open(sourceFile, false))
      using (var targetDocument = DM.Document.Create(targetFile))
      {
        var props = typeof(DM.BuiltInProperties).GetProperties().Where(p => p.GetCustomAttribute<DataMemberAttribute>() != null).ToArray();
        foreach (var property in props)
        {
          var val = property.GetValue(sourceDocument.BuiltInProperties);
          Output.WriteLine($"  Copying {property.Name} = {val.ToDumpString()}");
          property.SetValue(targetDocument.BuiltInProperties, val);
        }

        if (sourceDocument.HasCustomProperties)
        {
          foreach (var item in sourceDocument.CustomProperties!)
          {
            var val = item.Value;
            Output.WriteLine($"  {item.Name}: {val.ToDumpString()}");
            var newCustomProperty = (CustomProperty?)item.CopyDeep(ModelSerializer);
            if (newCustomProperty != null)
              targetDocument.ExistingCustomProperties.Add(newCustomProperty);
          }
        }
      }
      success = true;
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
    }
    if (success)
      success = TestReadProperties(targetFile);
    if (success)
      success = CompareDocxFiles(targetFile, sourceFile);
    return success;
  }

  object?[] newCustomPropValues = new object?[]
  {
    true, false,
    "simpleString", String.Empty,
    1, (byte)255, int.MaxValue, int.MinValue, long.MaxValue, long.MinValue,
    2.1f, 3.2d, 4.3m,
    DateTime.Parse("01.02.03 23:59"),
    DBNull.Value,
    null,
  };

  public bool TestCreateProperties()
  {
    bool success = false;
    var samplesPath = SamplesPath;
    var fileName = Path.Combine(samplesPath, "NewDocumentProperties.docx");
    var targetFile = Path.ChangeExtension(fileName, ".new.docx");
    var copyFile = Path.ChangeExtension(targetFile, ".copy.docx");
    Output.WriteLine($"TestCreateProperties: {targetFile}");
    try
    {
      using (var targetDocument = DM.Document.Create(targetFile))
      {
        var props = typeof(DM.BuiltInProperties).GetProperties().Where(p => p.GetCustomAttribute<DataMemberAttribute>() != null).ToArray();
        int n = 0;
        foreach (var prop in props)
        {
          object? val = GenerateValue(prop);
          Output.WriteLine($"  Setting {prop.Name} = {val.ToDumpString()}");
          prop.SetValue(targetDocument.BuiltInProperties, val);
        }
        foreach (var item in newCustomPropValues)
        {
          var typeName = item?.GetType().Name ?? "null";
          var val = item;
          var propName = $"CustomProperty_{++n} ({typeName})";
          Output.WriteLine($"  Setting {propName} = {val.ToDumpString()}");
          targetDocument.ExistingCustomProperties.Add(propName, val);
        }
        targetDocument.SaveAs(copyFile);
        using (var copyDocument = DM.Document.Open(copyFile, false))
          success = CompareDocuments(copyDocument, targetDocument);
      }
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
    }
    if (success)
      success = TestReadProperties(targetFile);
    return success;
  }

  public bool TestCreateSettings()
  {
    bool success = false;
    var samplesPath = SamplesPath;
    var fileName = Path.Combine(samplesPath, "NewDocumentSettings.docx");
    var targetFile = Path.ChangeExtension(fileName, ".new.docx");
    var copyFile = Path.ChangeExtension(targetFile, ".copy.docx");
    Output.WriteLine($"TestCreateSettings: {targetFile}");
    try
    {
      using (var targetDocument = DM.Document.Create(targetFile))
      {
        var props = typeof(DMW.DocumentSettings).GetProperties().Where(p => p.GetCustomAttribute<DataMemberAttribute>() != null).ToArray();
        foreach (var prop in props)
        {
          object? val = GenerateValue(prop);
          Output.WriteLine($"  Setting {prop.Name} = {val.ToDumpString()}");
          prop.SetValue(targetDocument.DocumentSettings, val);
        }
        targetDocument.SaveAs(copyFile);
        using (var copyDocument = DM.Document.Open(copyFile, false))
          success = CompareDocuments(copyDocument, targetDocument);
      }
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
    }
    if (success)
      success = TestReadSettings(targetFile);
    return success;
  }

  static int n;
  static bool b;
  protected object? GenerateValue(PropertyInfo prop)
    => GenerateValue(prop.PropertyType, prop.Name);

  protected object? GenerateValue(Type aType, string propName)
  {
    if (aType.IsNullable(out var baseType))
      aType = baseType;
    //if (aType.Name=="CompatibilitySettings")
    //  Debug.Assert(true);
    if (aType == typeof(bool))
    {
      b = !b;
      return b;
    }
    else
    if (aType == typeof(string))
      return propName + (++n).ToString();
    else
    if (aType == typeof(int))
      return 1000000 + (++n);
    else
    if (aType == typeof(uint))
      return (uint)(1000000000 + (++n));
    else
    if (aType == typeof(UInt16))
      return (UInt16)(1000 + (++n));
    else
    if (aType == typeof(Int16))
      return (Int16)(1000 + (++n));
    else
    if (aType == typeof(Int64))
      return new Random().NextInt64();
    else
    if (aType == typeof(Guid))
    {
      var str = new Random().NextInt64().ToString("X16") + new Random().NextInt64().ToString("X16");
      var bytes = Convert.FromHexString(str);
      return new Guid(bytes);
    }
    else
    if (aType == typeof(Reference))
      return new Reference($"r{(++n)}");
    else
    if (aType == typeof(DateTime))
      return DateTime.Parse("01.02.03 23:59");
    else
    if (aType == typeof(StringList))
      return new StringList("str1", "str2", "str3");
    else
    if (aType.IsEnum)
    {
      var enumValues = aType.GetEnumValues();
      return enumValues.GetValue(new Random().Next(enumValues.Length));
    }
    else
    if (aType == typeof(HeadingPairs))
    {
      var headingPairs = new HeadingPairs();
      for (int i = 0; i < 3; i++)
        headingPairs.Add(new HeadingPair { Heading = "Heading" + i, Num = i * 10 });
      return headingPairs;
    }
    else
    if (aType == typeof(HyperlinkList))
    {
      var hyperlinkList = new HyperlinkList();
      var actions = Enum.GetValues<HyperlinkAction>();
      var attachments = Enum.GetValues<HyperlinkAttachment>();
      for (int i = 0; i < Math.Max(actions.Length, attachments.Length); i++)
        hyperlinkList.Add(new HyperlinkInfo
        {
          N1 = 1,
          N2 = 2,
          N3 = 3,
          Action = actions[i % actions.Length],
          Attachment = attachments[i % attachments.Length],
          Location = "location" + (i + 1),
          Target = "url://target" + (i + 1)
        });
      return hyperlinkList;
    }
    else
    if (aType == typeof(byte[]))
    {
      var bytes = new byte[10];
      for (var i = 0; i < 10; i++)
        bytes[i] = (byte)(i + 1);
      return bytes;
    }
    else
    if (aType == typeof(DM.HexBinary))
    {
      var bytes = new byte[10];
      for (var i = 0; i < 10; i++)
        bytes[i] = (byte)(i + 1);
      return new HexBinary(bytes);
    }
    else
    if (aType == typeof(DM.HexWord))
    {
      return new HexWord(new Random().Next(UInt16.MaxValue));
    }
    else
    if (aType == typeof(DM.HexInt))
    {
      return new HexInt(new Random().Next());
    }
    else
    if (aType == typeof(DM.Percent))
    {
      return new Percent(new Random().NextDouble());
    }
    else
    if (aType == typeof(DM.Twips))
    {
      return new Twips(new Random().Next());
    }
    else
    if (aType.IsClass)
    {
      var constructor = aType.GetConstructor(new Type[0]);
      if (constructor == null)
        throw new NotImplementedException($"Property type {aType} should have parameterless constructor");
      var value = constructor.Invoke(new object[0]);
      var props = aType.GetProperties().Where(p => p.GetCustomAttribute<DataMemberAttribute>() != null).ToArray();
      foreach (var prop in props)
      {
        //if (prop1.Name=="CryptographicProviderTypeExtSource")
        //  Debug.Assert(true);
        object? val = GenerateValue(prop);
        Output.WriteLine($"  Setting {aType}.{prop.Name} = {val.ToDumpString()}");
        prop.SetValue(value, val);
      }
      if (value.GetType().IsCollection(out var collectionItemType))
      {

        for (var i = 0; i < 5; i++)
        {
          var val = GenerateValue(collectionItemType, $"item{i + 1}");
          if (val != null)
          {
            Output.WriteLine($"  Adding {aType}({val.ToDumpString()})");
            var addMethod = value.GetType().GetMethod("Add", new Type[] { val.GetType() });
            Debug.Assert(addMethod != null);
            if (addMethod != null)
              addMethod.Invoke(value, new object[] { val });
          }
        }
      }
      return value;
    }
    else
      throw new NotImplementedException($"Can't generate value of type {aType}");
  }

}