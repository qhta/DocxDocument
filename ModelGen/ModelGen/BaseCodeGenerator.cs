using DocumentFormat.OpenXml;


namespace ModelGen;

public abstract class BaseCodeGenerator
{
  public string SolutionName { get; protected set; } = null!;
  public string ProjectName { get; protected set; } = null!;
  public string OutputPath { get; protected set; } = null!;
  public string? ConfigPath { get; protected set; } = null!;

  public bool CancelRequest { get; set; }


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

  #region Generation
  public int GenerateCode(IEnumerable<Namespace> nspaces, ProgressTypeEvent? _OnGeneratingType)
  {
    if (ModelConfig.Instance == null)
      throw new System.InvalidOperationException(CommonStrings.Model_configuration_not_defined);
    PrepareProject();
    var allTypes = new Dictionary<Namespace, TypeInfo[]>();
    var totalTypesCount = 0;
    var nspacesCount = 0;
    var generatedTypesCount = 0;
    foreach (var nspace in nspaces.ToArray())
    {
      if (nspace.TargetName != null)
      {
        CreateNamespaceFolder(nspace.TargetName);
        var types = nspace.AcceptedTypesTo(PPS.CodeGen).Where(item => !item.IsConstructedGenericType
        && !ModelConfig.Instance.PredefinedTypes.Contains(item.Type.FullName!)).ToArray();

        allTypes.Add(nspace, types);
        totalTypesCount += types.Count();
      }
    }
    foreach (var item in allTypes)
    {
      var nspace = item.Key;
      var nsTypesCount = 0;
      foreach (var type in item.Value)
      {
        _OnGeneratingType?.Invoke(new ProgressTypeInfo
        {
          Namespaces = nspacesCount,
          ProcessedTypes = generatedTypesCount,
          TotalTypes = totalTypesCount,
          Current = type
        });
        if (GenerateTypeFile(type))
        {
          nsTypesCount++;
          generatedTypesCount++;
        }
      }
      if (nsTypesCount > 0)
      {
        AddGlobalUsing(nspace.TargetName!);
        nspacesCount++;
      }
    }

    GenerateGlobalUsings();
    return generatedTypesCount;
  }

  public abstract bool GenerateTypeFile(TypeInfo typeInfo);

  public FilesList GeneratedFiles { get; protected set; } = new FilesList();

  public void PrepareProject()
  {
    if (!Directory.Exists(OutputPath))
      Directory.CreateDirectory(OutputPath);
    ClearProjectFolder(OutputPath);
    CopyProjectFile(ProjectName, OutputPath, ConfigPath);
    InitGlobalUsings(ProjectName, ConfigPath);
  }

  protected void ClearProjectFolder(string path)
  {
    var subfolders = Directory.GetDirectories(path);
    foreach (var subfolder in subfolders)
    {
      ClearProjectFolder(subfolder);
    }
    if (!path.EndsWith("Extensions"))
    {
      foreach (var file in Directory.GetFiles(path))
      {
        if (file.EndsWith(".cs") && Path.GetFileName(file).Count(ch => ch == '.') == 1)
        {
          try
          {
            File.Delete(file);
          }
          catch
          {
            Debug.WriteLine($"Could not delete file \"{file}\"");
          }
        }
      }
      try
      {
        if (Directory.GetFiles(path).Count() == 0 && Directory.GetDirectories(path).Count() == 0)
          Directory.Delete(path, false);
      }
      catch
      {
        Debug.WriteLine($"Could not delete folder \"{path}\"");
      }
    }
  }

  protected bool CopyProjectFile(string projectName, string outputPath, string? configPath)
  {
    string? sourceFilename;
    if (configPath != null)
      sourceFilename = Path.Combine(configPath, projectName + ".csproj.xml");
    else
      sourceFilename = projectName + ".csproj.xml";
    if (!File.Exists(sourceFilename))
    {
      Debug.WriteLine($"Project template file \"{sourceFilename}\" not found");
      return false;
    }
    var outputFilename = Path.Combine(outputPath, projectName + ".csproj");
    AssurePathExists(outputFilename);
    using (var writer = File.CreateText(outputFilename))
    using (var reader = File.OpenText(sourceFilename))
    {
      var s = reader.ReadToEnd();
      writer.Write(s);
    }
    return true;
  }

  #endregion

  #region CustomAttributes generation

  protected bool GenerateCustomAttributes(IEnumerable<CustomAttribInfo>? attributes)
  {
    if (attributes?.Any() == true)
    {
      bool generated = false;
      foreach (var customAttrib in attributes)
      {
        if (!customAttrib.Name.StartsWith("Nullable") && !customAttrib.Name.StartsWith("SchemaAttr"))
        {
          if (customAttrib.IsAcceptedTo(PPS.CodeGen))
            if (GenerateCustomAttribute(customAttrib))
              generated = true;
        }
      }
      return (generated);
    }
    return false;
  }

  protected bool GenerateCustomAttribute(CustomAttribInfo attrData)
  {
    var kind = TypeKind.type;
    var attributeType = attrData.AttributeTypeInfo;
    var attributeTypeName = attributeType.GetConvertedName(kind);
    var attrTypeName = attributeTypeName.Name;
    //if (attrTypeName.EndsWith("Attribute"))
    //  attrTypeName = attrTypeName.Substring(0, attrTypeName.Length - "Attribute".Length);
    if (attrTypeName == string.Empty)
      return false;
    //if (ModelConfig.Instance.ExcludedTypes.Contains(attrTypeName))
    //  return false;
    if (!attributeType.IsAcceptedTo(PPS.CodeGen))
      return false;
    var attrString = attrTypeName.Substring(0, attrTypeName.Length - "Attribute".Length);
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

  protected bool InitGlobalUsings(string projectName, string? configPath)
  {
    string? sourceFilename;
    if (configPath != null)
      sourceFilename = Path.Combine(configPath, projectName + ".globalUsings.cs.txt");
    else
      sourceFilename = projectName + ".globalUsings.cs.txt";
    if (!File.Exists(sourceFilename))
    {
      Debug.WriteLine($"Global usings file \"{sourceFilename}\" not found");
      return false;
    }
    using (var reader = File.OpenText(sourceFilename))
    {
      string? line;
      while ((line = reader.ReadLine()) != null)
      {
        var str = line.Trim();
        if (str.Length != 0)
        {
          str = str.ReplaceStart("global using ", "");
          str = str.Replace(";", "").Trim();
          AddGlobalUsing(str);
        }
      }
    }
    return true;
  }

  protected bool CreateNamespaceFolder(string ns)
  {
    if (ns.StartsWith(ProjectName + "."))
      ns = ns.Substring(ProjectName.Length + 1);
    else
    if (ns == ProjectName)
      ns = "";
    return CreateNamespaceFolder(ProjectName, System.IO.Path.Combine(OutputPath, ns));
  }

  protected bool CreateNamespaceFolder(string projectName, string nsPath)
  {
    if (!Directory.Exists(nsPath))
      Directory.CreateDirectory(nsPath);
    return true;
  }

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
    if (ModelConfig.Instance == null)
      throw new System.InvalidOperationException(CommonStrings.Model_configuration_not_defined);

    AssurePathExists(filename);
    using (var writer = File.CreateText(filename))
    {
      foreach (var item in GlobalUsings)
      {
        if (ModelConfig.Instance.NamespaceShortcuts.TryGetValue(item, out var shortcut))
          writer.WriteLine($"global using {shortcut} = {item};");
        else
          writer.WriteLine($"global using {item};");
      }
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

  protected virtual bool AssureDirectoryExists(string dirName)
  {
    if (dirName.Contains(@"\Properties"))
      return false;
    if (!Directory.Exists(dirName))
      Directory.CreateDirectory(dirName);
    return true;
  }

  protected virtual bool AssurePathExists(string filename)
  {

    var filePath = Path.GetDirectoryName(filename) ?? string.Empty;
    var fileName = Path.GetFileName(filename);
    if (filePath.EndsWith("Classes"))
      Debug.Assert(true);
    if (!Directory.Exists(filePath))
      Directory.CreateDirectory(filePath);
    var commonPath = Path.GetDirectoryName(OutputPath);
    var folderName = filePath.ReplaceStart(commonPath + @"\", "");
    if (GeneratedFiles != null)
    {
      FolderModel? compilationFolder = RegisterCompilationFolder(GeneratedFiles, folderName);
      if (compilationFolder != null)
        compilationFolder.Add(new FileModel(fileName));
    }
    return true;
  }

  private FolderModel? RegisterCompilationFolder(FilesList compilationFiles, string fullFolderName)
  {
    var ss = fullFolderName.Split(@"\");
    var path = string.Empty;
    FolderModel? compilationFolder = null;
    foreach (var folderName in ss)
    {
      if (!compilationFiles.TryGetValue(folderName, out var compilationFile))
      {
        compilationFolder = new FolderModel(folderName);
        compilationFiles.Add(folderName, compilationFolder);
      }
      else
        compilationFolder = (FolderModel)compilationFile;
      compilationFiles = compilationFolder.Items;
    }
    return compilationFolder;
  }

  public CompilationErrors CompileCode()
  {
    string solutionPath = Path.GetDirectoryName(OutputPath)!;
    var solutionName = SolutionName + ".sln";
    var outputTxtFile = ProjectName + ".txt";

    Directory.SetCurrentDirectory(solutionPath);
    File.Delete(outputTxtFile);
    var compileExe = "c:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\devenv.exe";
    var args = $"/build debug {solutionName} /out {outputTxtFile}";
    var process = Process.Start(compileExe, args);
    process.WaitForExit();
    CompilationErrors errors = new();
    using (var reader = File.OpenText(outputTxtFile))
    {
      string? line;
      while ((line = reader.ReadLine()) != null)
      {
        var errorTag = ": error ";
        var k = line.IndexOf(errorTag);
        if (k != -1)
        {
          var filename = line.Substring(2, k - 2).Trim();
          filename = filename.ReplaceStart(solutionPath + @"\", "");
          var l = filename.IndexOf('(');
          if (l != -1)
            filename = filename.Substring(0, l).Trim();
          k += errorTag.Length;
          l = line.IndexOf(':', k);
          var code = line.Substring(k, l - k).Trim();
          var description = line.Substring(l + 2).Trim();
          l = description.IndexOf('(');
          if (l != -1)
            description = description.Substring(0, l).Trim();
          var error = new CompilationError { Filename = filename, Code = code, Description = description };
          errors.Add(error);
        }
      }
    }
    return errors;
  }

}