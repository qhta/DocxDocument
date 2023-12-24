using Namotion.Reflection;

namespace ModelGen;

/// <summary>
/// Base creator
/// </summary>
public class Creator
{
  /// <summary>
  /// Assembly of DocumentFormat.OpenXml.dll
  /// </summary>
  protected Assembly SourceAssembly { [DebuggerStepThrough] get; set; } = null!;

  /// <summary>
  /// Total count of types in SourceAssembly
  /// </summary>
  protected int TotalTypesCount { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Name of the C# project. Base of the namespace.
  /// </summary>
  protected string ProjectName { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Base path of directories to create the structure of the output files.
  /// </summary>
  protected string OutputPath { [DebuggerStepThrough] get; set; }


  public bool CancelRequest
  {
    get => ModelManager.CancelRequest;
    set
    {
      ModelManager.CancelRequest = value;
      CodeGenerator.CancelRequest = value;
    }
  }

  public bool IsRun { [DebuggerStepThrough] get; set; }

  public PPS PhaseDone { [DebuggerStepThrough] get; private set; }

  public ModelMonitor? ModelMonitor { [DebuggerStepThrough] get; set; }

  public BaseCodeGenerator CodeGenerator { [DebuggerStepThrough] get; set; } = null!;

  public Creator(ProcessOptions options)
  {
    if (options.ProjectName == null)
      throw new InvalidOperationException(CommonStrings.Project_name_not_defined);
    if (options.CodeOutputPath == null)
      throw new InvalidOperationException(CommonStrings.Code_output_path_not_defined);
    if (options.GeneratorType == null)
      throw new InvalidOperationException(CommonStrings.Generator_type_not_defined);
    var generatorType = ProcessOptionsMgr.GetGeneratorTypes().FirstOrDefault(item => item.Name == options.GeneratorType);
    if (generatorType == null)
      throw new InvalidOperationException(CommonStrings.Generator_type_not_found);
    var codeGenerator = generatorType.GetConstructor(new Type[] { typeof(ProcessOptions) })?.Invoke(new object[] { options }) as BaseCodeGenerator;
    if (codeGenerator == null)
      throw new InvalidOperationException(CommonStrings.Generator_type_constructor_not_found);
    CodeGenerator = codeGenerator;
    ProjectName = options.ProjectName;
    OutputPath = options.CodeOutputPath;
  }

  public void RunProcess(ProcessOptions options, bool continueProcess = false)
  {
    if (options.InputAssembly == null)
      throw new InvalidOperationException(CommonStrings.Input_assembly_not_defined);
    if (options.ScanTypeName == null)
      throw new InvalidOperationException(CommonStrings.Scan_type_name_not_defined);
    if (continueProcess && PhaseDone > PPS.None)
    {
      Debug.Assert(RootType != null);
      RunOn(RootType, options, true);
    }
    else
    {
      var assembly = Assembly.Load(options.InputAssembly);
      Debug.Assert(assembly != null);
      RootType = assembly.GetType(options.ScanTypeName, true);
      Debug.Assert(RootType != null);
      RunOn(RootType, options);
    }
  }

  protected ProcessOptions Options { [DebuggerStepThrough] get; set; } = new ProcessOptions();

  protected Type? RootType = null!;

  public PPS StopAtPhase
  {
    get
    {
      return _StopAtPhase ??
        (PPS)Enum.ToObject(typeof(PPS), Options.StopAtPhase);
    }
    set { _StopAtPhase = value; }
  }
  private PPS? _StopAtPhase = null!;

  public bool CanContinue => PhaseDone < StopAtPhase;

  public HashSet<TypeInfo> InvalidTypes { [DebuggerStepThrough] get; private set; } = new();
  public HashSet<PropInfo> InvalidProps { [DebuggerStepThrough] get; private set; } = new();

  public virtual void RunOn(Type type, ProcessOptions options, bool continueProcess = false)
  {
    Options = options;
    IsRun = true;

    var displayOptions = new DisplayOptions();

    var monitorDisplaySelector = MDS.None;

    if (CancelRequest)
      return;
    InvalidTypes.Clear();
    InvalidProps.Clear();
    ModelMonitor?.ShowProcessStart(
        (continueProcess ? CommonStrings.ProcessContinue : CommonStrings.ProcessStart) + ":\n" + type.FullName);
    SourceAssembly = type.Assembly;
    TotalTypesCount = SourceAssembly.ExportedTypes.Count();
    TimeSpan totalTime = TimeSpan.Zero;
    if (!continueProcess)
      PhaseDone = PPS.None;

    if (!continueProcess)
      TypeManager.Clear();

    if (StopAtPhase >= PPS.ScanSource && PhaseDone < PPS.ScanSource && !CancelRequest)
    {
      totalTime += ScanTypes(type);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedNamespaces))
        ModelMonitor?.ShowNamespaceSummary(PPS.ScanSource, NTS.Origin);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedTypes))
        ModelMonitor?.ShowNamespacesDetails(PPS.ScanSource, displayOptions with { NamespaceTypeSelector = NTS.Origin });
      if (!CancelRequest)
        PhaseDone = PPS.ScanSource;
    }

    if (StopAtPhase >= PPS.AddDocs && PhaseDone < PPS.AddDocs && !CancelRequest)
    {
      totalTime += AddDocs();
      if (monitorDisplaySelector.HasFlag(MDS.ScannedNamespaces))
        ModelMonitor?.ShowNamespaceSummary(PPS.ScanSource, NTS.Origin);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedTypes))
        ModelMonitor?.ShowNamespacesDetails(PPS.ScanSource, displayOptions with { NamespaceTypeSelector = NTS.Origin });
      if (!CancelRequest)
        PhaseDone = PPS.AddDocs;
    }

    if (StopAtPhase >= PPS.Rename && PhaseDone < PPS.Rename && !CancelRequest)
    {
      totalTime += RenameNamespacesAndTypes();
      if (monitorDisplaySelector.HasFlag(MDS.TypeRename))
        ModelMonitor?.ShowTypeRenames();
      if (!CancelRequest)
        PhaseDone = PPS.Rename;
    }

    if (StopAtPhase >= PPS.ConvertTypes && PhaseDone < PPS.ConvertTypes && !CancelRequest)
    {
      totalTime += ConvertTypes();
      if (monitorDisplaySelector.HasFlag(MDS.TypeConversions))
        ModelMonitor?.ShowTypeConversions();
      if (!CancelRequest)
        PhaseDone = PPS.ConvertTypes;
    }

    if (StopAtPhase >= PPS.FinalFix && PhaseDone < PPS.FinalFix && !CancelRequest)
    {
      totalTime += FinalCheck();
      if (monitorDisplaySelector.HasFlag(MDS.FinalCheck))
        ModelMonitor?.ShowFinalCheck();
      if (!CancelRequest)
        PhaseDone = PPS.FinalFix;
    }

    if (StopAtPhase >= PPS.CodeGen && PhaseDone < PPS.CodeGen && !CancelRequest)
    {
      totalTime += GenerateCode();
      //if (monitorDisplaySelector.HasFlag(MDS.CodeGen))
      //  ModelMonitor?.Show();
      if (!CancelRequest)
        PhaseDone = PPS.CodeGen;
    }

    ModelMonitor?.ShowProcessSummary(new SummaryInfo
    {
      ProcessCancelled = CancelRequest,
      Time = totalTime
    });
    IsRun = false;
  }

  #region Processing methods

  #region Scan types
  protected TimeSpan ScanTypes(Type startingType)
  {
    ModelMonitor?.ShowPhaseStart(PPS.ScanSource, CommonStrings.ScanSource);
    DateTime t1 = DateTime.Now;
    var summaryInfo = ModelManager.ScanTypes(startingType, ModelManager_OnScanningType);

    if (Options.ValidateScan && !CancelRequest)
    {
      var modelValidator = new ModelValidator(PPS.ScanSource, NTS.Origin, MSS.Accepted, TDS.Metadata);
      var types = TypeManager.AllTypes.Where(type => type.IsAcceptedAfter(PPS.ScanSource)).ToArray();
      if (!modelValidator.ValidateTypes(types, ModelValidator_OnValidatingType))
      {
        var invalidTypesCount = modelValidator.InvalidTypesCount;
        summaryInfo.Summary.Add(SummaryInfoKind.InvalidTypes, invalidTypesCount);
        if (invalidTypesCount > 0)
          InvalidTypes.AddRange(modelValidator.InvalidTypes);
      }
    }

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    summaryInfo.Time = ts;

    ModelMonitor?.ShowPhaseEnd(PPS.ScanSource, summaryInfo);
    return ts;
  }

  private void ModelManager_OnScanningType(ProgressTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.ScanSource, new ProgressInfo
    {
      FormatStr = CommonStrings.registered_0_of_1_types_in_2_namespaces,
      Args = new object[] { info.ProcessedTypes ?? 0, TotalTypesCount, info.Namespaces ?? 0 },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
    }); ;
  }
  #endregion

  #region Add docs
  protected TimeSpan AddDocs()
  {
    if (String.IsNullOrEmpty(Options.ModelDocFileName))
      return new TimeSpan(0);
    if (!File.Exists(Options.ModelDocFileName))
      return new TimeSpan(0);
    ModelMonitor?.ShowPhaseStart(PPS.AddDocs, CommonStrings.AddDocs);
    DateTime t1 = DateTime.Now;
    var ModelDocumenter = new ModelDocsManager(PPS.AddDocs, NTS.Origin, MSS.Accepted, Options.ModelDocFileName);
    var types = TypeManager.AllTypes.Where(typeInfo => typeInfo.IsAcceptedTo(PPS.AddDocs)
              && typeInfo.OriginalNamespace.StartsWith("DocumentFormat")
              && !typeInfo.IsConstructedGenericType
              && !typeInfo.IsGenericTypeDefinition).ToArray();
    var documentedTypesCount = ModelDocumenter.DocumentTypes(types, ModelDocumenter_OnDocumentingType);
    var summaryInfo = new SummaryInfo
    {
      Summary = new Dictionary<SummaryInfoKind, object>{
        {SummaryInfoKind.TypesWithAddedDescription, documentedTypesCount}
      }
    };

    if (Options.ValidateDocs && !CancelRequest)
    {
      var modelValidator = new ModelValidator(PPS.AddDocs, NTS.Origin, MSS.Accepted, TDS.Metadata);
      if (!modelValidator.ValidateTypes(types, ModelValidator_OnValidatingType))
      {
        var invalidTypesCount = modelValidator.InvalidTypesCount;
        summaryInfo.Summary.Add(SummaryInfoKind.InvalidTypes, invalidTypesCount);
        if (invalidTypesCount > 0)
        {
          InvalidTypes.AddRange(modelValidator.InvalidTypes);

          var typesWithoutDescriptionCount = modelValidator.InvalidTypes
            .Count(item => item.HasError(PPS.AddDocs, ErrorCode.MissingDescription));
          if (typesWithoutDescriptionCount > 0)
            summaryInfo.Summary.Add(SummaryInfoKind.TypesWithoutDescription, typesWithoutDescriptionCount);

          var typesWithMeaninglessDescriptionCount = modelValidator.InvalidTypes
            .Count(item => item.HasError(PPS.AddDocs, ErrorCode.MeaninglessDescription));
          if (typesWithMeaninglessDescriptionCount > 0)
            summaryInfo.Summary.Add(SummaryInfoKind.TypesWithMeaninglessDescription, typesWithMeaninglessDescriptionCount);
        }
      }
    }

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    summaryInfo.Time = ts;

    ModelMonitor?.ShowPhaseEnd(PPS.AddDocs, summaryInfo);
    return ts;
  }

  private void ModelDocumenter_OnDocumentingType(ProgressTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.AddDocs, new ProgressInfo
    {
      FormatStr = CommonStrings.adding_docs_0_of_1_types_added_to_2_types,
      Args = new object[] { info.CheckedTypes ?? 0, TotalTypesCount, info.ProcessedTypes ?? 0 },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
    });
  }
  #endregion

  protected TimeSpan RenameNamespacesAndTypes()
  {
    ModelMonitor?.ShowPhaseStart(PPS.Rename, CommonStrings.RenameTypes);
    DateTime t1 = DateTime.Now;
    var types = TypeManager.AllTypes.Where(typeInfo => typeInfo.IsAcceptedTo(PPS.Rename)
              && typeInfo.OriginalNamespace.StartsWith("DocumentFormat")
              && !typeInfo.IsConstructedGenericType
              && !typeInfo.IsGenericTypeDefinition).ToArray();
    TotalTypesCount = types.Count();
    var renamedTypesCount = ModelManager.RenameNamespacesAndTypes(types, ModelManager_OnRenamingType);
    var summaryInfo = new SummaryInfo
    {
      Summary = new Dictionary<SummaryInfoKind, object>{
        {SummaryInfoKind.RenamedTypes, renamedTypesCount },
        }
    };
    var duplicatedNamesCount = ModelManager.DuplicatedNamesCount;

    if (Options.ValidateNames && !CancelRequest)
    {
      var modelValidator = new ModelValidator(PPS.Rename, NTS.Origin, MSS.Accepted, TDS.Metadata);
      if (!modelValidator.ValidateTypes(types, ModelValidator_OnValidatingType))
      {
        var invalidTypesCount = modelValidator.InvalidTypesCount;
        summaryInfo.Summary.Add(SummaryInfoKind.InvalidTypes, invalidTypesCount);
        if (invalidTypesCount > 0)
          InvalidTypes.AddRange(modelValidator.InvalidTypes);
      }
      duplicatedNamesCount = modelValidator.InvalidTypesCount;
    }

    if (duplicatedNamesCount > 0)
      summaryInfo.Summary.Add(SummaryInfoKind.TypesWithSameName, duplicatedNamesCount);

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    summaryInfo.Time = ts;

    ModelMonitor?.ShowPhaseEnd(PPS.Rename, summaryInfo);
    return ts;
  }

  private void ModelManager_OnRenamingType(ProgressTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.Rename, new ProgressInfo
    {
      FormatStr = CommonStrings.renaming_0_of_1_types_renamed_2_types,
      Args = new object[] { info.CheckedTypes ?? 0, info.TotalTypes ?? 0, info.ProcessedTypes ?? 0 },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName} -> {info.Current?.GetTargetNamespace()}.{info.Current?.Name}"
    });
  }

  protected TimeSpan ConvertTypes()
  {
    ModelMonitor?.ShowPhaseStart(PPS.ConvertTypes, CommonStrings.ConvertTypes);
    DateTime t1 = DateTime.Now;

    var convertedTypesCount = ModelManager.ConvertTypes(ModelManager_OnConvertingType);
    var summaryInfo = new SummaryInfo
    {
      Summary = new Dictionary<SummaryInfoKind, object>{
        {SummaryInfoKind.ConvertedTypes, convertedTypesCount },
        }
    };

    if (Options.ValidateConversion && !CancelRequest)
    {
      var modelValidator = new ModelValidator(PPS.ConvertTypes, NTS.Target, MSS.Accepted, TDS.Metadata);
      var newNS = TypeManager.AllNamespaces.Where(ns => ns.IsTarget).ToArray();
      var newTypes = TypeManager.AllNamespaces.Where(ns => ns.IsTarget)
        .SelectMany(ns => ns.Types)
        .Where(typeInfo => !typeInfo.IsGenericTypeDefinition).ToArray().ToArray();
      if (!modelValidator.ValidateTypes(newTypes, ModelValidator_OnValidatingType))
      {
        {
          var invalidTypesCount = modelValidator.InvalidTypesCount;
          summaryInfo.Summary.Add(SummaryInfoKind.InvalidTypes, invalidTypesCount);
          if (invalidTypesCount > 0)
            InvalidTypes.AddRange(modelValidator.InvalidTypes);
        }
        var invalidPropsCount = modelValidator.InvalidPropsCount;
        if (invalidPropsCount > 0)
        {
          InvalidProps.AddRange(modelValidator.InvalidProps);
          summaryInfo.Summary.Add(SummaryInfoKind.InvalidProperties, invalidPropsCount);
        }
      }
    }

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    summaryInfo.Time = ts;

    ModelMonitor?.ShowPhaseEnd(PPS.ConvertTypes, summaryInfo);
    return ts;
  }

  private void ModelManager_OnConvertingType(ProgressTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.ConvertTypes, new ProgressInfo
    {
      FormatStr = CommonStrings.converting_0_of_1_types_converted_2_types,
      Args = new object[] { info.CheckedTypes ?? 0, info.TotalTypes ?? 0, info.ProcessedTypes ?? 0 },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName} -> {info.Current?.GetTargetNamespace()}.{info.Current?.Name}"
    });
  }
  #endregion

  #region Final check
  protected TimeSpan FinalCheck()
  {
    ModelMonitor?.ShowPhaseStart(PPS.FinalFix, CommonStrings.FinalCheck);
    DateTime t1 = DateTime.Now;
    var fixedTypesCount = ModelManager.FinalFix(ModelManager_OnFinalCheck);
    var removedPropsCount = ModelManager.FixedProps.Count(item => item.IsRejectedAfter(PPS.FinalFix));
    var summaryInfo = new SummaryInfo
    {
      Summary = new Dictionary<SummaryInfoKind, object>{
        {SummaryInfoKind.FixedTypes, fixedTypesCount },
        {SummaryInfoKind.RemovedProperties, removedPropsCount },
        }
    };

    //var targetTypesCount = 0;
    //var invalidTypesCount = 0;
    //if (Options.ValidateFinalCheck && !CancelRequest)
    //{
    //  var ModelValidator = new ModelValidator(PPS.FinalCheck, NTS.Target, MSS.Accepted, TDS.Metadata);
    //  var newNS = TypeManager.AllNamespaces.Where(ns => ns.IsTarget).ToArray();
    //  var newTypes = TypeManager.AllNamespaces.Where(ns => ns.IsTarget)
    //    .SelectMany(ns => ns.Types)
    //    .Where(typeInfo => !typeInfo.IsGenericTypeDefinition).ToArray().ToArray();
    //  targetTypesCount = newTypes.Count();
    //  if (!ModelValidator.ValidateTypes(newTypes, ModelValidator_OnValidatingType))
    //  {
    //    invalidTypesCount = ModelValidator.InvalidTypesCount;
    //  }
    //}

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    summaryInfo.Time = ts;

    ModelMonitor?.ShowPhaseEnd(PPS.FinalFix, summaryInfo);
    return ts;
  }

  private void ModelManager_OnFinalCheck(ProgressTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.FinalFix, new ProgressInfo
    {
      FormatStr = CommonStrings.checked_0_of_1_types,
      Args = new object[] { info.CheckedTypes ?? 0, info.TotalTypes ?? 0 },
      PostStr = $"{info.Current?.GetTargetNamespace()}.{info.Current?.Name}"
    });
  }
  #endregion

  #region Code generation
  protected TimeSpan GenerateCode()
  {
    ModelMonitor?.ShowPhaseStart(PPS.CodeGen, CommonStrings.GenerateCode);
    DateTime t1 = DateTime.Now;
    var nspaces = TypeManager.AllNamespaces.Where(item => item.IsTarget
    && !ModelConfig.Instance!.ExcludedNamespaces.Contains(item.OriginalName));
    var generatedTypesCount = CodeGenerator.GenerateCode(nspaces, CodeGenerator_OnGeneratingCode);
    var summaryInfo = new SummaryInfo
    {
      Summary = new Dictionary<SummaryInfoKind, object>{
        {SummaryInfoKind.GeneratedTypes, generatedTypesCount },
        }
    };
    var generatedFiles = CodeGenerator.GeneratedFiles;
    var generatedFilesCount = generatedFiles.TotalCount;
    if (generatedFilesCount > 0)
    {
      summaryInfo.Summary.Add(SummaryInfoKind.GeneratedFiles, generatedFilesCount);
      if (generatedFiles != null)
        summaryInfo.Summary.Add(SummaryInfoKind.GeneratedFileList, generatedFiles);
    }
    if (Options.ValidateGeneration && !CancelRequest)
    {
      ModelMonitor?.WriteLine(CommonStrings.CodeCompilation);
      var compilationErrors = CodeGenerator.CompileCode();
      if (compilationErrors != null)
      {
        summaryInfo.Summary.Add(SummaryInfoKind.CompilationErrors, compilationErrors.Count);
        summaryInfo.Summary.Add(SummaryInfoKind.CompilationErrorList, compilationErrors);
      }
    }

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    summaryInfo.Time = ts;

    ModelMonitor?.ShowPhaseEnd(PPS.CodeGen, summaryInfo);
    return ts;
  }

  private void CodeGenerator_OnGeneratingCode(ProgressTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.CodeGen, new ProgressInfo
    {
      FormatStr = CommonStrings.generated_0_of_1_types_in_2_namespaces,
      Args = new object[] { info.ProcessedTypes ?? 0, TotalTypesCount, info.Namespaces ?? 0 },
      PostStr = $"{info.Current?.TargetNamespace}.{info.Current?.TargetName}"
    });
  }
  #endregion


  private void ModelValidator_OnValidatingType(ModelValidator sender, ValidatingTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(sender.PhaseNum, new ProgressInfo
    {
      FormatStr = CommonStrings.verifying_0_of_1_types_invalid_2_types,
      Args = new object[] { info.CheckedTypes ?? 0, info.TotalTypes ?? 0, info.InvalidTypes ?? 0 },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
    });
  }

  #region SaveData
  public void SaveData()
  {
    SaveData(GetFilename());
  }

  public void SaveData(string filename)
  {
    using (var xmlWriter = XmlWriter.Create(filename, new XmlWriterSettings { Indent = true }))
    {
      var xmlSerializer = new QXmlSerializer(typeof(Creator));
      xmlSerializer.Serialize(xmlWriter, this);
    }
  }

  public string GetFilename()
  {
    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    path = Path.Combine(path, "ModelGen");
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    path = Path.Combine(path, $"Phase {PhaseDone} result.xml");
    return path;
  }
  #endregion

}

