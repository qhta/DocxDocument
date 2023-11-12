using DocumentModel;

using Qhta.TypeUtils;

namespace DocxDocument.Test;

public class ReadWriteTest : ReadTest
{
  public Qhta.Xml.Serialization.QXmlSerializer ModelSerializer = 
    new(typeof(DocumentModel.Document), typeof(DocumentModel.Document).Assembly.GetExportedTypes(), 
      new SerializationOptions{ AcceptAllProperties = false, AcceptDataMembers = true });

  public bool TestCreate()
  {
    bool success = false;
    var samplesPath = SamplesPath;
    var file = Path.Combine(samplesPath, "TestCreate.docx");
    Output.WriteLine($"TestCreate: {file}");
    try
    {
      using (var document = DM.Document.Create(file))
        Output.WriteLine($"  Type: {document.DocumentType}");
      success=true;
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
    }
    if (success)
      success = TestReadProperties(file);
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
    var targetFile = Path.ChangeExtension(sourceFile,".new.docx");
    Output.WriteLine($"TestCopyProperties: {sourceFile} -> {targetFile}");
    try
    {
      using (var sourceDocument = DM.Document.Open(sourceFile, false))
      using (var targetDocument = DM.Document.Create(targetFile))
      {
        var props = typeof(DM.BuiltInProperties).GetProperties().Where(p=>p.GetCustomAttribute<DataMemberAttribute>()!=null).ToArray();
        foreach (var property in props) 
        {
          var val = property.GetValue(sourceDocument.BuiltInProperties);
          Output.WriteLine($"  Copying {property.Name} = {TestUtilities.ToDumpString(val)}");
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
      success = CompareDocuments(targetFile, sourceFile);
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
    var targetFile = Path.ChangeExtension(fileName,".new.docx");
    Output.WriteLine($"TestCreateProperties: {targetFile}");
    try
    {
      using (var targetDocument = DM.Document.Create(targetFile))
      {
        var props = typeof(DM.BuiltInProperties).GetProperties().Where(p=>p.GetCustomAttribute<DataMemberAttribute>()!=null).ToArray();
        int n=0;
        foreach (var prop in props) 
        {          
          var propType = prop.PropertyType;
          if (propType.IsNullable(out var baseType))
            propType = baseType;
          object? val = null;
          if (propType == typeof(bool))
            val = true;
          else
          if (propType == typeof(string))
            val = prop.Name+"_value";
          else
          if (propType == typeof(int))
            val = 1000000000 + (++n);
          else
          if (propType == typeof(DateTime))
            val = DateTime.Parse("01.02.03 23:59");
          else
          if (propType == typeof(StringList))
            val = new StringList("str1", "str2", "str3");
          else
          if (propType == typeof(HeadingPairs))
          {
            var headingPairs = new HeadingPairs();
            for (int i = 0; i < 3; i++)
              headingPairs.Add(new HeadingPair{ Heading = "Heading"+i, Num=i*10 });
            val = headingPairs;
          }
          else
          if (propType == typeof(HyperlinkList))
          {
            var hyperlinkList = new HyperlinkList();
            var actions = Enum.GetValues<HyperlinkAction>();
            var attachments = Enum.GetValues<HyperlinkAttachment>();
            for (int i = 0; i < Math.Max(actions.Length, attachments.Length); i++)
              hyperlinkList.Add(new HyperlinkInfo
              { 
                N1 = 1, N2 = 2, N3 = 3, 
                Action = actions[i % actions.Length],
                Attachment = attachments[i % attachments.Length],
                Location = "location" + (i + 1),
                Target = "url://target" + (i + 1)
              });
            val = hyperlinkList;
          }
          else
            throw new NotImplementedException($"Property type {propType} not supported");
          Output.WriteLine($"  Setting {prop.Name} = {TestUtilities.ToDumpString(val)}");
          prop.SetValue(targetDocument.BuiltInProperties, val);
        }

        n=0;
        foreach (var item in newCustomPropValues)
        {
          var typeName = item?.GetType().Name ?? "null";
          var val = item;

          var propName = $"CustomProperty_{++n} ({typeName})";
          Output.WriteLine($"  Setting {propName} = {TestUtilities.ToDumpString(val)}");
          targetDocument.ExistingCustomProperties.Add(propName, val);
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
    return success;
  }

}