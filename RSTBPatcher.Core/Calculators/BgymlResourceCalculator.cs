namespace RSTBPatcher.Core.Calculators;

public class BgymlResourceCalculator : IResourceCalculator
{
    public static uint CalculateSizeOffset(Stream stream, string romfsName)
    {
        string filenameLower = Path.GetFileName(romfsName).ToLowerInvariant();

        if (filenameLower.EndsWith(".alto__altoconfig.bgyml")) return 0xB10;
        if (romfsName.EndsWith("ui__SystemParam.bgyml")) return 0x1568;
        if (romfsName.EndsWith("ui__SnapshotCamera.bgyml")) return 0x360;
        if (romfsName.EndsWith("ui__Parts3DLayoutParam.bgyml")) return 0x400 + 0x8;
        if (romfsName.EndsWith("ui__MessageSystem.bgyml")) return 0x400;
        if (romfsName.EndsWith("sound__VoicePlayParam.bgyml")) return 0x1CD8;
        if (romfsName.EndsWith("sound__VoiceLanguageOffset.bgyml")) return 0x708;
        if (romfsName.EndsWith("sound__OutputDeviceSetting.bgyml")) return 0x388;
        if (romfsName.EndsWith("sound__LeakOutSetting.bgyml")) return 0x730;
        if (romfsName.EndsWith("sound__LeakOutParam.bgyml")) return 0x400 + 0x10;
        if (romfsName.EndsWith("sound__IgnoreDuckingSetting.bgyml")) return 0x3E0;
        if (romfsName.EndsWith("sound__FaderDuckingParam.bgyml")) return 0x4E0;
        if (romfsName.EndsWith("sound__ChimeSetting.bgyml")) return 0x820;
        if (romfsName.EndsWith("sound__CameraLinkSetting.bgyml")) return 0x3C8;
        if (romfsName.EndsWith("sound__AIBgmCtrlParam.bgyml")) return 0x360;
        if (romfsName.EndsWith("pp__CombinationDataTableData.bgyml")) return 0x3688;
        if (romfsName.EndsWith("phive__RigidBodyEntityParam.bgyml")) return 0x458;
        if (romfsName.EndsWith("phive__RigidBodyControllerEntityParam.bgyml")) return 0x640;
        if (romfsName.EndsWith("gfx__OceanSystemParam.bgyml")) return 0x570;
        if (romfsName.EndsWith("actor__ActorColorVariationSetting.bgyml")) return 0x360;
        if (romfsName.EndsWith("actor__AccidentSystemParam.bgyml")) return 0x360;

        if (filenameLower.Contains("bodyhelperbone")) return 0x120 + 0x7C28;
        if (filenameLower.Contains("miinewsparam")) return 0x120 + 0x2070;
        if (filenameLower.Contains("focusleading")) return 0x120 + 0x19A8;
        if (filenameLower.Contains("phive__")) return 0x120 + 0x1590 + 0x240;
        if (filenameLower.Contains("actorparam") || filenameLower.Contains("decoparam")) return 0x120 + 0xFA8 + 0x240;
        if (filenameLower.Contains("parameter") || filenameLower.Contains("component")) return 0x120 + 0x3568 + 0x240;

        return 0xB54;
    }
}