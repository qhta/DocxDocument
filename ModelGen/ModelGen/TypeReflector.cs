using DocumentFormat.OpenXml.Wordprocessing;

using Namotion.Reflection;

using System.Diagnostics;
using System.Reflection;

namespace ModelGen;

public static class TypeReflector
{

  private static Queue<TypeInfo> TypeQueue = new Queue<TypeInfo>();

  public static void RequestReflect(this TypeInfo typeInfo)
  {
    if (typeInfo.IsReflected)
      return;
    lock (typeInfo)
    {
      if (!TypeQueue.Contains(typeInfo))
        TypeQueue.Enqueue(typeInfo);
      if (!isStarted) Start();
    }
  }

  private static bool isStarted => ReflectionTasks is not null;
  private static int TaskCount = 2;
  private static Task[] ReflectionTasks = null!;
  private static int RunTrials = 100;
  public static void Start()
  {
    ReflectionTasks = new Task[TaskCount];
    for (int i = 0; i < TaskCount; i++)
    {
      ReflectionTasks[i] = new Task(() =>
      {
        var trials = RunTrials;
        do
        {
          trials--;
          if (TypeQueue.Any())
          {
            TypeInfo? typeInfo = null;
            lock (TypeQueue)
            {
              if (TypeQueue.Count>0)
                typeInfo = TypeQueue.Dequeue();
              else
              {
                typeInfo = null;
              }
            }
            if (typeInfo != null)
            {
              DoReflect(typeInfo);
              trials = RunTrials;
            }
            else
              Thread.Sleep(10);
          }
        } while (trials > 0);
      });
      ReflectionTasks[i].Start();
    }
  }


  public static void WaitDone()
  {
    if (ReflectionTasks is not null)
      Task.WaitAll(ReflectionTasks);
  }

  public static void WaitForReflection(this TypeInfo typeInfo)
  {
    while (typeInfo.IsReflected == false)
    {
      Thread.Sleep(100);
    }
  }

  public static object reflectedLock = new ();
  public static int reflected;
  public static void DoReflect(this TypeInfo typeInfo)
  {
    if (typeInfo.IsReflected)
      return;
    typeInfo.IsReflected = true;
    lock (reflectedLock)
    {
      reflected++;
      ModelDisplay.ConsoleWriteSameLine(
        $"Total {TypeManager.TotalTypesCount} registered types, {reflected} reflected, {TypeQueue.Count} waiting. {typeInfo.Namespace}.{typeInfo.Name}");
    }
    //if (typeInfo.Name == "DataPart")
    //  Debug.Assert(true);
    var type = typeInfo.Type;
    typeInfo.TypeKind = TypeKind.Type;
    if (type.IsEnum)
    {
      typeInfo.TypeKind = TypeKind.Enum;
      if (typeInfo.EnumValues == null)
        typeInfo.EnumValues = new Collection<EnumInfo>(typeInfo);
      foreach (var item in type.GetFields(BindingFlags.Static | BindingFlags.Public))
        typeInfo.EnumValues.Add(new EnumInfo(item));
    }
    else if ((type.IsClass || type.IsInterface || type.IsValueType) && type != typeof(string) && type != typeof(object))
    {
      typeInfo.TypeKind = (type.IsInterface) ? TypeKind.Interface : (type.IsClass) ? TypeKind.Class : TypeKind.Struct;
      if (typeInfo.Properties == null)
        typeInfo.Properties = new Collection<PropInfo>(typeInfo);
      foreach (var item in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
        typeInfo.Properties.Add(new PropInfo(item));
      if (type.BaseType != null && type.BaseType != typeof(object) && type.BaseType != typeof(ValueType))
      {
        typeInfo.BaseTypeInfo = TypeManager.RegisterType(type.BaseType, typeInfo, Semantics.Inheritance);
      }

      if (type.ContainsGenericParameters)
      {
        var genericTypeParameters = type.GetGenericArguments().ToList();
        if (genericTypeParameters.Any())
        {
          foreach (var argType in genericTypeParameters)
            TypeManager.RegisterType(argType, typeInfo, Semantics.GenericTypeParam);
        }
      }

      if (type.IsGenericTypeParameter)
      {
        var genericTypeParamConstraints = type.GetGenericParameterConstraints().ToList();
        if (genericTypeParamConstraints.Any())
        {
          foreach (var constraint in genericTypeParamConstraints)
            TypeManager.RegisterType(constraint, type, Semantics.GenericTypeParamConstraint);
        }
      }

      var genericTypeArguments = type.GenericTypeArguments.ToList();
      if (genericTypeArguments.Any())
      {
        foreach (var argType in genericTypeArguments)
        {
          TypeManager.RegisterType(argType, typeInfo, Semantics.GenericTypeArg);
        }
      }

      var implementedInterfaces = type.GetInterfaces().ToList();
      if (implementedInterfaces.Any())
      {
        foreach (var intf in implementedInterfaces)
        {
          TypeManager.RegisterType(intf, typeInfo, Semantics.Implementation);
        }
      }

      ModelManager.TryAddTypeConversion(typeInfo);
    }

    typeInfo.Documentation = type.GetXmlDocsElement();
    if (typeInfo.Documentation != null)
    {
      typeInfo.Summary = DocumentationReader.GetSummaryFirstPara(typeInfo.Documentation);
      var childItemTypes = DocumentationReader.GetChildItemTypes(typeInfo.Documentation, type.Assembly);
      if (childItemTypes != null)
      {
        foreach (var childItemType in childItemTypes)
          TypeManager.RegisterType(childItemType, typeInfo, Semantics.Include);
      }

    }
    foreach (var item in type.CustomAttributes)
      typeInfo.CustomAttributes.Add(new CustomAttribData(item));
  }

}