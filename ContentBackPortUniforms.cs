using System.Reflection;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
namespace ContentBackPortUniforms;
[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 2)]
public class ContentBackPortUniforms(
    WTTServerCommonLib.WTTServerCommonLib wttCommon
) : IOnLoad
{
    public async Task OnLoad()
    {
        var assembly = Assembly.GetExecutingAssembly();
        await wttCommon.CustomClothingService.CreateCustomClothing(assembly);
        await Task.CompletedTask;
    }
}