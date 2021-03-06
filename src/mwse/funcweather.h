
#include "mwseinstruction.h"

struct mwseSetSkyColour : public mwseInstruction
{
    mwseSetSkyColour(TES3MACHINE& mach) : mwseInstruction(mach) { vptr = &vtable; }
    static __fastcall bool execute(mwseInstruction *_this);

private:
    static vtable_t vtable;
};

struct mwseSetFogColour : public mwseInstruction
{
    mwseSetFogColour(TES3MACHINE& mach) : mwseInstruction(mach) { vptr = &vtable; }
    static __fastcall bool execute(mwseInstruction *_this);

private:
    static vtable_t vtable;
};

struct mwseSetAmbientColour : public mwseInstruction
{
    mwseSetAmbientColour(TES3MACHINE& mach) : mwseInstruction(mach) { vptr = &vtable; }
    static __fastcall bool execute(mwseInstruction *_this);

private:
    static vtable_t vtable;
};

struct mwseSetSunColour : public mwseInstruction
{
    mwseSetSunColour(TES3MACHINE& mach) : mwseInstruction(mach) { vptr = &vtable; }
    static __fastcall bool execute(mwseInstruction *_this);

private:
    static vtable_t vtable;
};

struct mwseSetSunriseSunset : public mwseInstruction
{
    mwseSetSunriseSunset(TES3MACHINE& mach) : mwseInstruction(mach) { vptr = &vtable; }
    static __fastcall bool execute(mwseInstruction *_this);

private:
    static vtable_t vtable;
};

struct mwseSetScattering : public mwseInstruction
{
    mwseSetScattering(TES3MACHINE& mach) : mwseInstruction(mach) { vptr = &vtable; }
    static __fastcall bool execute(mwseInstruction *_this);

private:
    static vtable_t vtable;
};
