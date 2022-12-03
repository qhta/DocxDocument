using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel;
using DocumentFormat.OpenXml.Wordprocessing;

using Namotion.Reflection;

using System.Diagnostics;
using System.Reflection;

namespace ModelGen;

public static class TypeReflector
{

  private static Queue<TypeInfo> TypeQueue = new Queue<TypeInfo>();

  public static void ReflectTypeAsync(this TypeInfo typeInfo)
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
              ReflectType(typeInfo);
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
    int count = 10;
    while (typeInfo.IsReflected == false && (count--)>0)
    {
      Thread.Sleep(10);
    }
    if (!typeInfo.IsReflected)
      ReflectType(typeInfo);
  }

  public static object reflectedLock = new ();
  public static int reflected;
  public static void ReflectType(this TypeInfo typeInfo)
  {
    if (typeInfo.IsReflected)
      return;
    typeInfo.IsReflected = true;
    lock (reflectedLock)
    {
      reflected++;
      ModelDisplay.ConsoleWriteSameLine(
        $"Total {TypeManager.TotalTypesCount} registered types, {reflected} reflected, {TypeQueue.Count} waiting. {typeInfo.OriginalNamespace}.{typeInfo.OriginalName}");
    }
    //if (typeInfo.Name == "DataPart")
    //  Debug.Assert(true);
    var type = typeInfo.Type;
    typeInfo.TypeKind = TypeKind.Type;
    if (type.IsEnum)
    {
      typeInfo.TypeKind = TypeKind.Enum;
      if (typeInfo.EnumValues == null)
        typeInfo.EnumValues = new OwnedCollection<EnumInfo>(typeInfo);
      foreach (var item in type.GetFields(BindingFlags.Static | BindingFlags.Public))
        typeInfo.EnumValues.Add(new EnumInfo(item));
    }
    else if ((type.IsClass || type.IsInterface || type.IsValueType) && type != typeof(string) && type != typeof(object))
    {
      typeInfo.TypeKind = (type.IsInterface) ? TypeKind.Interface : (type.IsClass) ? TypeKind.Class : TypeKind.Struct;
      if (typeInfo.Properties == null)
        typeInfo.Properties = new OwnedCollection<PropInfo>(typeInfo);
      foreach (var item in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
      {
        if (!item.PropertyType.Name.EndsWith('&'))
          typeInfo.Properties.Add(new PropInfo(item));
      }
      if (type.BaseType != null && type.BaseType != typeof(object) && type.BaseType != typeof(ValueType))
      {
        typeInfo.BaseTypeInfo = TypeManager.RegisterType(type.BaseType, typeInfo, Semantics.Inheritance);
      }

      if (type.ContainsGenericParameters)
      {
        var genericTypeParameters = type.GetGenericArguments();
        if (genericTypeParameters.Any())
        {
          foreach (var argType in genericTypeParameters)
            TypeManager.RegisterType(argType, typeInfo, Semantics.GenericTypeParam);
        }
      }

      if (type.IsGenericTypeParameter)
      {
        var genericTypeParamConstraints = type.GetGenericParameterConstraints();
        if (genericTypeParamConstraints.Any())
        {
          foreach (var constraint in genericTypeParamConstraints)
            TypeManager.RegisterType(constraint, type, Semantics.GenericTypeParamConstraint);
        }
      }

      var genericTypeArguments = type.GenericTypeArguments;
      if (genericTypeArguments.Any())
      {
        int cnt = 0;
        foreach (var argType in genericTypeArguments)
        {
          var argTypeInfo = TypeManager.RegisterType(argType);
          var rel = TypeManager.AddRelationship(typeInfo, argTypeInfo, Semantics.GenericTypeArg, ++cnt);
        }
      }

      var implementedInterfaces = type.GetInterfaces();
      if (implementedInterfaces.Any())
      {
        foreach (var intf in implementedInterfaces)
        {
          TypeManager.RegisterType(intf, typeInfo, Semantics.Implementation);
        }
      }
    }

    typeInfo.Documentation = type.GetXmlDocsElement();
    if (typeInfo.Documentation != null)
    {
      typeInfo.Summary = DocumentationReader.GetSummaryFirstPara(typeInfo.Documentation);
      //var childItemTypes = DocumentationReader.GetChildItemTypes(typeInfo.Documentation, type.Assembly);
      //if (childItemTypes != null)
      //{
      //  foreach (var childItemType in childItemTypes)
      //    TypeManager.RegisterType(childItemType, typeInfo, Semantics.Include);
      //}

    }
    TypeInspector.InspectType(typeInfo);
    foreach (var includeRelationship in typeInfo.GetOutgoingRelationships(Semantics.Include))
    {
      if (typeInfo.Properties == null)
        typeInfo.Properties = new OwnedCollection<PropInfo>(typeInfo);
      if (includeRelationship.IsMultiple == true)
      {
        var propName = MultipleItemsPropName(includeRelationship.Target.Name);
        if (!typeInfo.Properties.Any(item => item.Name == propName))
        {
          var propInfo = new PropInfo(includeRelationship.Target);
          propInfo.Name = propName;
          Type propertyType = typeof(System.Collections.ObjectModel.Collection<>).MakeGenericType(new Type[] { includeRelationship.Target.Type });
          propInfo.PropertyType = TypeManager.RegisterType(propertyType);
          typeInfo.Properties.Add(propInfo);
        }
      }
      else
      {
        if (!typeInfo.Properties.Any(item=>item.Name == includeRelationship.Target.Name))
          typeInfo.Properties.Add(new PropInfo(includeRelationship.Target));
      }
    }


    foreach (var item in type.CustomAttributes)
      typeInfo.CustomAttributes.Add(new CustomAttribData(item));
  }

  private static string MultipleItemsPropName(string aName)
  {
    if (aName.EndsWith('y'))
      return aName.Substring(0, aName.Length - 1) + "ies";
    else if (aName.EndsWith('s'))
      return aName + "es";
    return aName + "s";
  }
}