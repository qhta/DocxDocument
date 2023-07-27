using DocumentFormat.OpenXml;


namespace ModelGen;

public class BaseCodeGenerator
{
  public string ProjectName { get; protected set; } = null!;
  public string OutputPath { get; protected set; } = null!;


  public int GeneratedClassesCount { get; protected set; }
  public int GeneratedInterfacesCount { get; protected set; }
  public int GeneratedStructsCount { get; protected set; }
  public int GeneratedEnumTypesCount { get; protected set; }
  public int GeneratedPropertiesCount { get; protected set; }
  public int GeneratedEnumValuesCount { get; protected set; }

  protected IndentedTextWriter Writer { get; set; } = null!;

  protected void TrimNamespace(FullTypeName typeName)
  {
    if (typeName.Namespace != null)
    {
      if (typeName.Namespace.StartsWith("System"))
      {
        AddGlobalUsing(typeName.Namespace);
        typeName.Namespace = null;
      }
    }
  }

  protected string TrimDocumentModel(string nspace)
  {
    if (nspace.StartsWith("DocumentModel"))
    {
      nspace = nspace.Substring("DocumentModel".Length);
      if (nspace.StartsWith('.'))
        nspace = nspace.Substring(1);
    }
    return nspace;
  }

  #region CustomAttributes generation

  protected bool GenerateCustomAttributes(IEnumerable<CustomAttrib>? attributes)
  {
    if (attributes?.Any() == true)
    {
      bool generated = false;
      foreach (var customAttrib in attributes)
      {
        if (customAttrib.IsAccepted is true)
          if (GenerateCustomAttribute(customAttrib))
            generated = true;
      }
      return (generated);
    }
    return false;
  }

  protected bool GenerateCustomAttribute(CustomAttrib attrData)
  {
    var kind = TypeKind.Type;
    var attributeType = attrData.AttributeTypeInfo;
    var attributeTypeName = attributeType.GetConvertedName(kind);
    var attrTypeName = attributeTypeName.Name;
    if (attrTypeName.EndsWith("Attribute"))
      attrTypeName = attrTypeName.Substring(0, attrTypeName.Length - "Attribute".Length);
    if (attrTypeName == string.Empty)
      return false;
    if (ModelConfig.Instance.ExcludedAttributes.Contains(attrTypeName))
      return false;
    var attrString = attrTypeName;
    if (attrData.ConstructorArguments?.Count + attrData.NamedArguments?.Count > 0)
    {
      var strList = new List<string>();
      if (attrData.ConstructorArguments != null)
        foreach (var arg in attrData.ConstructorArguments)
          strList.Add(GenerateTypedValueLiteral(arg, kind));
      if (attrData.NamedArguments != null)
        foreach (var arg in attrData.NamedArguments)
          strList.Add(CreateTypedValueLiteral(arg, kind));
      attrString += "(" + String.Join(", ", strList) + ")";
    }
    Writer.WriteLine($"[{attrString}]");
    if (attributeTypeName.Namespace != null)
      AddGlobalUsing(attributeTypeName.Namespace);
    return true;
  }
  #endregion

  #region Documentation comments generation

  protected bool GenerateDocumentationComments(ModelElement element)
  {
    var documentation = element.GetDocumentation();
    if (documentation != null)
    {
      Writer.WriteLine();
      foreach (var item in documentation)
      {
        var documentationWriter = new DocumentationWriter(Writer, Writer.Indent, 0);
        documentationWriter.Write(item);
      }
      return true;
    }
    return false;
  }

  #endregion

  #region Global usings generation


  SortedSet<string> GlobalUsings { get; } = new();

  protected void AddGlobalUsing(string aNamespace)
  {
    if (aNamespace != String.Empty)
      if (!GlobalUsings.Contains(aNamespace))
        GlobalUsings.Add(aNamespace);

  }

  public bool GenerateGlobalUsings()
  {
    return GenerateGlobalUsings(Path.Combine(OutputPath, "GlobalUsings.cs"));
  }

  protected bool GenerateGlobalUsings(string filename)
  {
    AssurePathExists(filename);
    using (var writer = File.CreateText(filename))
    {
      foreach (var item in GlobalUsings)
        writer.WriteLine($"global using {item};");
    }
    return true;
  }
  #endregion

  #region Literals generation
  protected string CreateTypedValueLiteral(CustomAttribNamedArgument namedArgument, TypeKind kind)
  {
    return namedArgument.Name + "=" + GenerateTypedValueLiteral(namedArgument.Value, kind);
  }

  protected string GenerateTypedValueLiteral(object? value, TypeKind kind)
  {
    if (value is string str)
    {
      return $"\"{str}\"";
    }
    else if (value is TypeInfo aType)
    {
      var typeName = aType.GetConvertedName(kind);
      var aTypeName = typeName.Name;
      var aNamespace = typeName.Namespace;
      return ($"typeof({aNamespace}.{aTypeName})");
    }
    else if (value is bool bv)
      return bv.ToString().ToLower();
    else if (value != null)
    {
      var valueType = value.GetType();
      if (valueType.IsEnum)
      {
        var enumName = Enum.GetName(valueType, value);
        enumName = valueType.Name + "." + enumName;
        return enumName;
      }
      return value.ToString() ?? "null";
    }
    return "null";
  }
  #endregion

  #region Filename/Path methods
  protected string ValidateFilename(string filename)
  {
    foreach (var ch in Path.GetInvalidFileNameChars())
      filename = filename.Replace(new string(ch, 1), "");
    return filename;
  }

  #endregion

  protected virtual bool AssurePathExists(string filename)
  {
    if (File.Exists(filename))
      return false;
    var filePath = Path.GetDirectoryName(filename);
    if (filePath != null)
      if (!Directory.Exists(filePath))
      {
        Directory.CreateDirectory(filePath);
      }
    return true;
  }

}