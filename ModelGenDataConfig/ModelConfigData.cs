using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

using Qhta.Collections;
using Qhta.TextUtils;
using DM = DocumentModel;

namespace ModelGenDataConfig;

public class ModelConfigData
{

  public ModelConfigData(string? dataFolder)
  {
    InitPredefinedTypes();
    LoadData(dataFolder);
    DataFolder = dataFolder;
  }
  public string? DataFolder { get; private set; }

  #region Namespaces

  /// <summary>
  /// List of source namespaces that should be treated as origin namespaces.
  /// </summary>
  public WildcardStrings IncludedNamespaces { get; } = new WildcardStrings();

  /// <summary>
  /// List of origin namespaces that should be excluded from processing.
  /// </summary>
  public WildcardStrings ExcludedNamespaces { get; } = new WildcardStrings();

  /// <summary>
  /// Translation table of origin namespaces to target namespaces.
  /// </summary>
  public BiDiDictionary<string, string> TranslatedNamespaces { get; } = new BiDiDictionary<string, string>();

  /// <summary>
  /// Shortcuts for DocumentFormat.OpenXml namespaces. 
  /// Shortcuts for DocumentModel namespaces can be translated by replacing starting "DX" with "DM".
  /// Shortcuts for DocumentModel.OpenXml namespaces can be translated by replacing starting "DX" with "DXM".
  /// It is implemented in <see cref="NamespaceShortcut(string)"/> function.
  /// </summary>
  public BiDiDictionary<string, string> NamespaceShortcuts { get; } = new BiDiDictionary<string, string>();


  public string? NamespaceShortcut(string ns)
  {
    if (ns.StartsWith("System"))
      return null;
    if (NamespaceShortcuts.TryGetValue2(ns, out var shortcut))
      return shortcut;
    return null;
  }
  #endregion

  #region Properties

  public WildcardStrings ExcludedProperties { get; } = new WildcardStrings();

  public Dictionary<string, string> PropertyTranslateTable = new();

  public WildcardStringDictionary PropertyTypeConversion { get; } = new();

  public WildcardStringDictionary<Type> PropertyTypes { get; } = new();

  public void BuildPropertyTypesDictionary()
  {
    PropertyTypes.Clear();
    foreach (var item in PropertyTypeConversion)
    {
      if (item.Value.StartsWith("Collection<"))
      {
        var k = "Collection<".Length;
        var str = item.Value.Substring(k, item.Value.Length - k - 1);
        var type = GetType(str);
        if (type != null)
        {
          type = typeof(Collection<>).MakeGenericType(type);
          PropertyTypes.Add(item.Key, type);
        }
      }
      else
      {
        var typeName = item.Value;
        var type = GetType(typeName);
        if (type != null)
          PropertyTypes.Add(item.Key, type);
      }
    }
  }

  public bool TryGetPropertyType(string propertyName, [MaybeNullWhen(false)][NotNullWhen(true)] out Type propertyType)
  {
    if (PropertyTypes.Count == 0)
      BuildPropertyTypesDictionary();
    if (PropertyTypes.TryGetValue(propertyName, out propertyType))
      return true;
    var k = propertyName.IndexOf('.');
    while (k > 0)
    {
      var wildcardName = '*' + propertyName.Substring(k);
      if (PropertyTypes.TryGetValue(wildcardName, out propertyType))
        return true;
      k = propertyName.IndexOf(".", k + 1);
    }
    propertyType = null;
    return false;
  }

  #endregion

  #region Types
  public bool IsExcluded(Type type)
  {
    if (type.Namespace?.StartsWith("System") == true && !type.IsConstructedGenericType)
      return true;
    var fullNameComparison = IncludedTypes.FirstOrDefault(item => item.Contains('.')) != null
                          || ExcludedTypes.FirstOrDefault(item => item.Contains('.')) != null;
    if (fullNameComparison)
    {
      var fullName = type.Name;
      var ns = type.Namespace ?? "";
      if (type.Namespace != null)
        fullName = type.Namespace + "." + fullName;
      if (IncludedTypes.Contains(fullName))
        return false;
      if (ExcludedNamespaces.Contains(ns))
        return true;
      if (ExcludedTypes.Contains(fullName))
        return true;
    }
    else
    {
      if (IncludedTypes.Contains(type.Name))
        return false;
      if (ExcludedNamespaces.Contains(type.Namespace ?? ""))
        return true;
      if (ExcludedTypes.Contains(type.Name))
        return true;
    }
    return false;
  }

  public WildcardStrings ExcludedTypes { get; } = new ();

  public WildcardStrings IncludedTypes { get; } = new ();

  public BiDiDictionary<string, string> TypeConversion { get; } = new();

  public WildcardStrings PredefinedTypes { get; } = new ();

  public Dictionary<string, Type> ModelTypes { get; } = new();


  public void LoadModelTypes(Assembly assembly)
  {
    foreach (var type in assembly.GetTypes())
      ModelTypes.Add(type.FullName ?? "", type);
  }

  public BiDiDictionary<string, string> BuiltInTypeTranslation { get; } = new()
  {
    { "System.Object", "object" },
    { "System.String", "string" },
    { "System.Boolean", "bool" },
    { "System.Int32", "int"},
    { "System.UInt32", "uint"},
    { "System.Int16", "short" },
    { "System.UInt16", "ushort" },
    { "System.Int64", "long" },
    { "System.UInt64", "ulong" },
    { "System.Byte", "byte" },
    { "System.SByte", "sbyte" },
    { "System.Single", "float" },
    { "System.Double", "double" },
    { "System.Decimal", "decimal" },
  };

  public WildcardStrings SimpleTypes { get; } = new ()
  {
    nameof(System.String),
    nameof(System.Boolean),
    nameof(System.Int32),
    nameof(System.UInt32),
    nameof(System.Int16),
    nameof(System.UInt16),
    nameof(System.Int64),
    nameof(System.UInt64),
    nameof(System.Byte),
    nameof(System.SByte),
    nameof(System.Single),
    nameof(System.Double),
    nameof(System.Decimal),
  };

  #endregion

  #region Common type names
  public Dictionary<string, string> CommonTypes { get; } = new()
  {
    { "*Start", "*Mark" },
    { "*End", "*Mark" },
    { "MoveFromRangeMark", "EditRangeMark" },
    { "MoveToRangeMark", "EditRangeMark" },
    { "CustomXml*RangeMark", "EditRangeMark" },
    { "BookmarkMark", "AnnotationRangeMark" },
    { "CommentRangeMark", "AnnotationRangeMark" },
    { "DXW.Bidirectional*", "DXW.BidirectionalMark" },
    { "DXO10W.RunConflict*", "DXO10W.RunConflictMark" },
    { "DXW.AnnotationRangeMark|DXW.EditRangeMark|DXO10W.EditRangeMark", "DXW.RangeMark" },
    { "DXW.ProofError|DXW.PermMark", "DXW.ProofPermMark" },
    { "DXW.InsertedRun", "DXW.EditRunMark" },
    { "DXW.DeletedRun", "DXW.EditRunMark" },
    { "DXW.MoveFromRun", "DXW.EditRunMark" },
    { "DXW.MoveToRun", "DXW.EditRunMark" },
    { "DXW.ProofPermMark|DXW.RangeMark|DXW.EditRunMark|DXW.ContentPart|DXO10W.RunConflictMark", "DXW.CommonMark" },
    { "DXW.CustomXmlRun|DXW.SimpleField|DXW.Hyperlink", "DXW.ActiveRun" },
    { "DXW.ActiveRun|DXW.SdtRun|DXW.CommonMark|DXM.MathElement|DXW.Run|DXW.BidirectionalMark|DXW.SubDocumentReference", "DXW.ParagraphContent" },
    { "DXM.Accent", "DXM.MathOp" },
    { "DXM.Bar", "DXM.MathOp" },
    { "DXM.Box", "DXM.MathOp" },
    { "DXM.BorderBox", "DXM.MathOp" },
    { "DXM.Delimiter", "DXM.MathOp" },
    { "DXM.EquationArray", "DXM.MathOp" },
    { "DXM.Fraction", "DXM.MathOp" },
    { "DXM.MathFunction", "DXM.MathOp" },
    { "DXM.GroupChar", "DXM.MathOp" },
    { "DXM.LimitLower", "DXM.MathOp" },
    { "DXM.LimitUpper", "DXM.MathOp" },
    { "DXM.Matrix", "DXM.MathOp" },
    { "DXM.Nary", "DXM.MathOp" },
    { "DXM.Phantom", "DXM.MathOp" },
    { "DXM.Radical", "DXM.MathOp" },
    { "DXM.PreSubSuper", "DXM.MathOp" },
    { "DXM.Subscript", "DXM.MathOp" },
    { "DXM.SubSuperscript", "DXM.MathOp" },
    { "DXM.Superscript", "DXM.MathOp" },
    { "DXM.Run", "DXM.MathOp" },
    { "DXM.Paragraph|DXM.OfficeMath|DXM.MathOp", "DXM.MathElement" },
    { "DXW.*Border", "DXW.Border" },
    { "DXW.CustomXmlBlock|DXW.SdtBlock|DXW.Paragraph|DXW.Table", "DXW.TextBlock" },
  };

  public bool TryGetCommonTypeName(string name, [MaybeNullWhen(false)][NotNullWhen(true)] out string? newName)
  {
    if (CommonTypes.TryGetValue(name, out newName))
      return true;
    foreach (var item in CommonTypes)
    {
      if (name.IsLike(item.Key, out var wildKey, StringComparison.InvariantCulture))
      {
        newName = item.Value.Replace("*", wildKey);
        return true;
      }
    }
    newName = null;
    return false;
  }

  #endregion

  #region Validation info
  public WildcardStrings RealTypes = new()
  {
    "Int64","Int32","UInt32","Double","Boolean",
    "http://www.w3.org/2001/XMLSchema:hexBinary",
    "http://www.w3.org/2001/XMLSchema:integer",
  };
  #endregion

  #region Save & Load
  public void SaveData()
  {
    SaveDataInFile(GetFilename(DataFolder));
  }

  public void ReloadData()
  {
    LoadDataFromFile(GetFilename(DataFolder));
  }

  public void LoadData(string? dataFolder)
  {
    //Debug.WriteLine($"ModelConfigData.LoadData({dataFolder})");
    LoadDataFromFile(GetFilename(dataFolder));
    DataFolder = dataFolder;
  }

  public static string GetAppDataBase()
  {
    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    path = Path.Combine(path, "ModelGen");
    return path;
  }

  public string GetConfigPath()
  {
    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    path = Path.Combine(path, "ModelGen");
    if (DataFolder != null)
      path = Path.Combine(path, DataFolder);
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    return path;
  }

  public string GetFilename() => GetFilename(DataFolder);

  public string GetFilename(string? dataFolder)
  {
    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    path = Path.Combine(path, "ModelGen");
    if (dataFolder != null)
      path = Path.Combine(path, dataFolder);
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    path = Path.Combine(path, "ModelConfig.txt");
    return path;
  }

  public void SaveDataInFile(string filename)
  {
    using (var textWriter = File.CreateText(filename))
    {
      WriteStrings(textWriter, "IncludedNamespaces", IncludedNamespaces);
      WriteStrings(textWriter, "ExcludedNamespaces", ExcludedNamespaces);
      WriteDictionary(textWriter, "TranslatedNamespaces", TranslatedNamespaces);
      WriteDictionary(textWriter, "NamespaceShortcuts", NamespaceShortcuts);
      WriteStrings(textWriter, "IncludedTypes", IncludedTypes);
      WriteStrings(textWriter, "ExcludedTypes", ExcludedTypes);
      WriteDictionary(textWriter, "TypeConversion", TypeConversion);
      WriteStrings(textWriter, "ExcludedProperties", ExcludedProperties);
      WriteDictionary(textWriter, "PropertyTranslateTable", PropertyTranslateTable);
      WriteDictionary(textWriter, "PropertyTypeConversion", PropertyTypeConversion);

      WriteDictionary(textWriter, "BuiltInTypeTranslation", BuiltInTypeTranslation);
      WriteStrings(textWriter, "SimpleTypes", SimpleTypes);
      WriteStrings(textWriter, "RealTypes", RealTypes);
      WriteDictionary(textWriter, "CommonTypes", CommonTypes);
    }
  }

  public bool LoadDataFromFile(string filename)
  {
    if (File.Exists(filename))
    try
    {
      using (var textReader = File.OpenText(filename))
      {
        string? line;
        int lineNumber = 0;
        while ((line = textReader.ReadLine()) != null)
        {
          lineNumber++;
          line = line.Trim();
          if (line.Length == 0)
            continue;
          if (line.StartsWith("[") && line.EndsWith("]"))
          {
            var key = line.Substring(1, line.Length - 2);
            if (key == "IncludedNamespaces")
              ReadStrings(textReader, IncludedNamespaces, ref lineNumber);
            else if (key == "ExcludedNamespaces")
              ReadStrings(textReader, ExcludedNamespaces, ref lineNumber);
            else if (key == "TranslatedNamespaces")
              ReadDictionary(textReader, TranslatedNamespaces, ref lineNumber);
            else if (key == "NamespaceShortcuts")
              ReadDictionary(textReader, NamespaceShortcuts, ref lineNumber);
            else if (key == "IncludedTypes")
              ReadStrings(textReader, IncludedTypes, ref lineNumber);
            else if (key == "ExcludedTypes")
              ReadStrings(textReader, ExcludedTypes, ref lineNumber);
            else if (key == "TypeConversion")
            {
              ReadDictionary(textReader, TypeConversion, ref lineNumber);
            }
            else if (key == "ExcludedProperties")
              ReadStrings(textReader, ExcludedProperties, ref lineNumber);
            else if (key == "PropertyTranslateTable")
              ReadDictionary(textReader, PropertyTranslateTable, ref lineNumber);
            else if (key == "PropertyTypeConversion")
            {
              ReadDictionary(textReader, PropertyTypeConversion, ref lineNumber);
              PropertyTypes.Clear();
            }
            else if (key == "BuiltInTypeTranslation")
              ReadDictionary(textReader, BuiltInTypeTranslation, ref lineNumber);
            else if (key == "SimpleTypes")
              ReadStrings(textReader, SimpleTypes, ref lineNumber);
            else if (key == "RealTypes")
              ReadStrings(textReader, RealTypes, ref lineNumber);
            else if (key == "CommonTypes")
              ReadDictionary(textReader, CommonTypes, ref lineNumber);
            else
              throw new InvalidDataException($"Unrecognized key [{key}] expected in line {lineNumber}");
          }
          else
            throw new InvalidDataException($"[key] expected in line {lineNumber}");
        }
      }
    }
    catch { return false; }
    BuildPropertyTypesDictionary();
    return true;
  }

  public void InitPredefinedTypes()
  {
    PredefinedTypes.Clear();
    LoadPredefinedTypes(Assembly.Load("DocumentModel.BaseTypes"));
    LoadPredefinedTypes(Assembly.Load("DocumentModel.Attributes"));
    //foreach (var str in PredefinedTypes)
    //  Debug.WriteLine(str);
  }

  /// <summary>
  /// Adds types in imported assembly to excluded types.
  /// </summary>
  public void LoadPredefinedTypes(Assembly assembly)
  {
    foreach (var type in assembly.ExportedTypes)
      if (!type.IsConstructedGenericType)
        PredefinedTypes.Add(type.FullName ?? "");
  }

  private void WriteStrings(TextWriter textWriter, string caption, ICollection<string> data)
  {
    textWriter.WriteLine("[" + caption + "]");
    foreach (var item in data)
      textWriter.WriteLine(item);
    textWriter.WriteLine();
  }

  private void WriteDictionary(TextWriter textWriter, string caption, IDictionary<string, string> data)
  {
    textWriter.WriteLine("[" + caption + "]");
    foreach (var item in data)
      textWriter.WriteLine($"{item.Key}\t{item.Value}");
    textWriter.WriteLine();
  }


  private void ReadStrings(TextReader textReader, ICollection<string> data, ref int lineNumber)
  {
    data.Clear();
    string? line;
    while (!(String.IsNullOrEmpty(line = textReader.ReadLine())))
    {
      lineNumber++;
      try
      {
        data.Add(line.Trim());
      }
      catch (Exception ex)
      { throw new InvalidDataException($"{ex.Message} in line {lineNumber}"); }
    }
    lineNumber++;
  }

  private void ReadDictionary(TextReader textReader, IDictionary<string, string> data, ref int lineNumber)
  {
    data.Clear();
    string? line;
    while (!(String.IsNullOrEmpty(line = textReader.ReadLine())))
    {
      lineNumber++;
      var ss = line.Trim().Split('\t');
      //if (line.StartsWith("*Id"))
      //  Debug.Assert(true);
      try
      {
        if (ss.Length > 1)
          data.Add(ss[0], ss[1]);
        else
          data.Add(ss[0], string.Empty);
      }
      catch (Exception ex)
      { throw new InvalidDataException($"{ex.Message} in line {lineNumber}"); }
    }
    lineNumber++;

  }
  #endregion

  private Type? GetType(string typeName)
  {
    Type? result = null;
    string aNamespace = "";
    string aTypeName = typeName;
    var k = typeName.IndexOf(".");
    if (k != -1)
    {
      aNamespace = typeName.Substring(0, k);
      aTypeName = typeName.Substring(k + 1);
    }
    if (aNamespace == "" || aNamespace == "System")
    {
      var types = typeof(System.String).Assembly.GetTypes();
      result = types.FirstOrDefault(item => item.Name == typeName);
    }
    if (result == null)
    {
      if (aNamespace == "" || aNamespace == "DocumentModel")
      {
        var types = typeof(DocumentModel.ModelElement).Assembly.GetTypes();
        result = types.FirstOrDefault(item => item.Name == aTypeName);
      }
    }
    return result;
  }
}