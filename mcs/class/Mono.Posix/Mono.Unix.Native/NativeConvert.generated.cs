/*
 * This file was automatically generated by make-map from Mono.Posix.dll.
 *
 * DO NOT MODIFY.
 */

using System;
using System.Runtime.InteropServices;
using Mono.Unix.Native;

namespace Mono.Unix.Native {

	[CLSCompliant (false)]
	public sealed /* static */ partial class NativeConvert
	{
		private NativeConvert () {}

		private const string LIB = "MonoPosixHelper";

		private static void ThrowArgumentException (object value)
		{
			throw new ArgumentOutOfRangeException ("value", value,
				Locale.GetText ("Current platform doesn't support this value."));
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromAccessMode")]
		private static extern int FromAccessMode (AccessMode value, out Int32 rval);

		[Obsolete ("Use Mono.Unix.Native.AccessModes")]
		public static bool TryFromAccessMode (AccessMode value, out Int32 rval)
		{
			return FromAccessMode (value, out rval) == 0;
		}

		[Obsolete ("Use Mono.Unix.Native.AccessModes")]
		public static Int32 FromAccessMode (AccessMode value)
		{
			Int32 rval;
			if (FromAccessMode (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToAccessMode")]
		private static extern int ToAccessMode (Int32 value, out AccessMode rval);

		[Obsolete ("Use Mono.Unix.Native.AccessModes")]
		public static bool TryToAccessMode (Int32 value, out AccessMode rval)
		{
			return ToAccessMode (value, out rval) == 0;
		}

		[Obsolete ("Use Mono.Unix.Native.AccessModes")]
		public static AccessMode ToAccessMode (Int32 value)
		{
			AccessMode rval;
			if (ToAccessMode (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromConfStr")]
		private static extern int FromConfStr (ConfStr value, out Int32 rval);

		[Obsolete ("Use Mono.Unix.Native.ConfstrName")]
		public static bool TryFromConfStr (ConfStr value, out Int32 rval)
		{
			return FromConfStr (value, out rval) == 0;
		}

		[Obsolete ("Use Mono.Unix.Native.ConfstrName")]
		public static Int32 FromConfStr (ConfStr value)
		{
			Int32 rval;
			if (FromConfStr (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToConfStr")]
		private static extern int ToConfStr (Int32 value, out ConfStr rval);

		[Obsolete ("Use Mono.Unix.Native.ConfstrName")]
		public static bool TryToConfStr (Int32 value, out ConfStr rval)
		{
			return ToConfStr (value, out rval) == 0;
		}

		[Obsolete ("Use Mono.Unix.Native.ConfstrName")]
		public static ConfStr ToConfStr (Int32 value)
		{
			ConfStr rval;
			if (ToConfStr (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromError")]
		private static extern int FromError (Error value, out Int32 rval);

		[Obsolete ("Use Mono.Unix.Native.Errno")]
		public static bool TryFromError (Error value, out Int32 rval)
		{
			return FromError (value, out rval) == 0;
		}

		[Obsolete ("Use Mono.Unix.Native.Errno")]
		public static Int32 FromError (Error value)
		{
			Int32 rval;
			if (FromError (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToError")]
		private static extern int ToError (Int32 value, out Error rval);

		[Obsolete ("Use Mono.Unix.Native.Errno")]
		public static bool TryToError (Int32 value, out Error rval)
		{
			return ToError (value, out rval) == 0;
		}

		[Obsolete ("Use Mono.Unix.Native.Errno")]
		public static Error ToError (Int32 value)
		{
			Error rval;
			if (ToError (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromMmapProt")]
		private static extern int FromMmapProt (MmapProt value, out Int32 rval);

		[Obsolete ("Use Mono.Unix.Native.MmapProts")]
		public static bool TryFromMmapProt (MmapProt value, out Int32 rval)
		{
			return FromMmapProt (value, out rval) == 0;
		}

		[Obsolete ("Use Mono.Unix.Native.MmapProts")]
		public static Int32 FromMmapProt (MmapProt value)
		{
			Int32 rval;
			if (FromMmapProt (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToMmapProt")]
		private static extern int ToMmapProt (Int32 value, out MmapProt rval);

		[Obsolete ("Use Mono.Unix.Native.MmapProts")]
		public static bool TryToMmapProt (Int32 value, out MmapProt rval)
		{
			return ToMmapProt (value, out rval) == 0;
		}

		[Obsolete ("Use Mono.Unix.Native.MmapProts")]
		public static MmapProt ToMmapProt (Int32 value)
		{
			MmapProt rval;
			if (ToMmapProt (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromAccessModes")]
		private static extern int FromAccessModes (AccessModes value, out Int32 rval);

		public static bool TryFromAccessModes (AccessModes value, out Int32 rval)
		{
			return FromAccessModes (value, out rval) == 0;
		}

		public static Int32 FromAccessModes (AccessModes value)
		{
			Int32 rval;
			if (FromAccessModes (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToAccessModes")]
		private static extern int ToAccessModes (Int32 value, out AccessModes rval);

		public static bool TryToAccessModes (Int32 value, out AccessModes rval)
		{
			return ToAccessModes (value, out rval) == 0;
		}

		public static AccessModes ToAccessModes (Int32 value)
		{
			AccessModes rval;
			if (ToAccessModes (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromConfstrName")]
		private static extern int FromConfstrName (ConfstrName value, out Int32 rval);

		public static bool TryFromConfstrName (ConfstrName value, out Int32 rval)
		{
			return FromConfstrName (value, out rval) == 0;
		}

		public static Int32 FromConfstrName (ConfstrName value)
		{
			Int32 rval;
			if (FromConfstrName (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToConfstrName")]
		private static extern int ToConfstrName (Int32 value, out ConfstrName rval);

		public static bool TryToConfstrName (Int32 value, out ConfstrName rval)
		{
			return ToConfstrName (value, out rval) == 0;
		}

		public static ConfstrName ToConfstrName (Int32 value)
		{
			ConfstrName rval;
			if (ToConfstrName (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromDirectoryNotifyFlags")]
		private static extern int FromDirectoryNotifyFlags (DirectoryNotifyFlags value, out Int32 rval);

		public static bool TryFromDirectoryNotifyFlags (DirectoryNotifyFlags value, out Int32 rval)
		{
			return FromDirectoryNotifyFlags (value, out rval) == 0;
		}

		public static Int32 FromDirectoryNotifyFlags (DirectoryNotifyFlags value)
		{
			Int32 rval;
			if (FromDirectoryNotifyFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToDirectoryNotifyFlags")]
		private static extern int ToDirectoryNotifyFlags (Int32 value, out DirectoryNotifyFlags rval);

		public static bool TryToDirectoryNotifyFlags (Int32 value, out DirectoryNotifyFlags rval)
		{
			return ToDirectoryNotifyFlags (value, out rval) == 0;
		}

		public static DirectoryNotifyFlags ToDirectoryNotifyFlags (Int32 value)
		{
			DirectoryNotifyFlags rval;
			if (ToDirectoryNotifyFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromErrno")]
		private static extern int FromErrno (Errno value, out Int32 rval);

		public static bool TryFromErrno (Errno value, out Int32 rval)
		{
			return FromErrno (value, out rval) == 0;
		}

		public static Int32 FromErrno (Errno value)
		{
			Int32 rval;
			if (FromErrno (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToErrno")]
		private static extern int ToErrno (Int32 value, out Errno rval);

		public static bool TryToErrno (Int32 value, out Errno rval)
		{
			return ToErrno (value, out rval) == 0;
		}

		public static Errno ToErrno (Int32 value)
		{
			Errno rval;
			if (ToErrno (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromFcntlCommand")]
		private static extern int FromFcntlCommand (FcntlCommand value, out Int32 rval);

		public static bool TryFromFcntlCommand (FcntlCommand value, out Int32 rval)
		{
			return FromFcntlCommand (value, out rval) == 0;
		}

		public static Int32 FromFcntlCommand (FcntlCommand value)
		{
			Int32 rval;
			if (FromFcntlCommand (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToFcntlCommand")]
		private static extern int ToFcntlCommand (Int32 value, out FcntlCommand rval);

		public static bool TryToFcntlCommand (Int32 value, out FcntlCommand rval)
		{
			return ToFcntlCommand (value, out rval) == 0;
		}

		public static FcntlCommand ToFcntlCommand (Int32 value)
		{
			FcntlCommand rval;
			if (ToFcntlCommand (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromFilePermissions")]
		private static extern int FromFilePermissions (FilePermissions value, out UInt32 rval);

		public static bool TryFromFilePermissions (FilePermissions value, out UInt32 rval)
		{
			return FromFilePermissions (value, out rval) == 0;
		}

		public static UInt32 FromFilePermissions (FilePermissions value)
		{
			UInt32 rval;
			if (FromFilePermissions (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToFilePermissions")]
		private static extern int ToFilePermissions (UInt32 value, out FilePermissions rval);

		public static bool TryToFilePermissions (UInt32 value, out FilePermissions rval)
		{
			return ToFilePermissions (value, out rval) == 0;
		}

		public static FilePermissions ToFilePermissions (UInt32 value)
		{
			FilePermissions rval;
			if (ToFilePermissions (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromLockType")]
		private static extern int FromLockType (LockType value, out Int16 rval);

		public static bool TryFromLockType (LockType value, out Int16 rval)
		{
			return FromLockType (value, out rval) == 0;
		}

		public static Int16 FromLockType (LockType value)
		{
			Int16 rval;
			if (FromLockType (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToLockType")]
		private static extern int ToLockType (Int16 value, out LockType rval);

		public static bool TryToLockType (Int16 value, out LockType rval)
		{
			return ToLockType (value, out rval) == 0;
		}

		public static LockType ToLockType (Int16 value)
		{
			LockType rval;
			if (ToLockType (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromLockfCommand")]
		private static extern int FromLockfCommand (LockfCommand value, out Int32 rval);

		public static bool TryFromLockfCommand (LockfCommand value, out Int32 rval)
		{
			return FromLockfCommand (value, out rval) == 0;
		}

		public static Int32 FromLockfCommand (LockfCommand value)
		{
			Int32 rval;
			if (FromLockfCommand (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToLockfCommand")]
		private static extern int ToLockfCommand (Int32 value, out LockfCommand rval);

		public static bool TryToLockfCommand (Int32 value, out LockfCommand rval)
		{
			return ToLockfCommand (value, out rval) == 0;
		}

		public static LockfCommand ToLockfCommand (Int32 value)
		{
			LockfCommand rval;
			if (ToLockfCommand (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromMlockallFlags")]
		private static extern int FromMlockallFlags (MlockallFlags value, out Int32 rval);

		public static bool TryFromMlockallFlags (MlockallFlags value, out Int32 rval)
		{
			return FromMlockallFlags (value, out rval) == 0;
		}

		public static Int32 FromMlockallFlags (MlockallFlags value)
		{
			Int32 rval;
			if (FromMlockallFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToMlockallFlags")]
		private static extern int ToMlockallFlags (Int32 value, out MlockallFlags rval);

		public static bool TryToMlockallFlags (Int32 value, out MlockallFlags rval)
		{
			return ToMlockallFlags (value, out rval) == 0;
		}

		public static MlockallFlags ToMlockallFlags (Int32 value)
		{
			MlockallFlags rval;
			if (ToMlockallFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromMmapFlags")]
		private static extern int FromMmapFlags (MmapFlags value, out Int32 rval);

		public static bool TryFromMmapFlags (MmapFlags value, out Int32 rval)
		{
			return FromMmapFlags (value, out rval) == 0;
		}

		public static Int32 FromMmapFlags (MmapFlags value)
		{
			Int32 rval;
			if (FromMmapFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToMmapFlags")]
		private static extern int ToMmapFlags (Int32 value, out MmapFlags rval);

		public static bool TryToMmapFlags (Int32 value, out MmapFlags rval)
		{
			return ToMmapFlags (value, out rval) == 0;
		}

		public static MmapFlags ToMmapFlags (Int32 value)
		{
			MmapFlags rval;
			if (ToMmapFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromMmapProts")]
		private static extern int FromMmapProts (MmapProts value, out Int32 rval);

		public static bool TryFromMmapProts (MmapProts value, out Int32 rval)
		{
			return FromMmapProts (value, out rval) == 0;
		}

		public static Int32 FromMmapProts (MmapProts value)
		{
			Int32 rval;
			if (FromMmapProts (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToMmapProts")]
		private static extern int ToMmapProts (Int32 value, out MmapProts rval);

		public static bool TryToMmapProts (Int32 value, out MmapProts rval)
		{
			return ToMmapProts (value, out rval) == 0;
		}

		public static MmapProts ToMmapProts (Int32 value)
		{
			MmapProts rval;
			if (ToMmapProts (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromMountFlags")]
		private static extern int FromMountFlags (MountFlags value, out UInt64 rval);

		public static bool TryFromMountFlags (MountFlags value, out UInt64 rval)
		{
			return FromMountFlags (value, out rval) == 0;
		}

		public static UInt64 FromMountFlags (MountFlags value)
		{
			UInt64 rval;
			if (FromMountFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToMountFlags")]
		private static extern int ToMountFlags (UInt64 value, out MountFlags rval);

		public static bool TryToMountFlags (UInt64 value, out MountFlags rval)
		{
			return ToMountFlags (value, out rval) == 0;
		}

		public static MountFlags ToMountFlags (UInt64 value)
		{
			MountFlags rval;
			if (ToMountFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromMremapFlags")]
		private static extern int FromMremapFlags (MremapFlags value, out UInt64 rval);

		public static bool TryFromMremapFlags (MremapFlags value, out UInt64 rval)
		{
			return FromMremapFlags (value, out rval) == 0;
		}

		public static UInt64 FromMremapFlags (MremapFlags value)
		{
			UInt64 rval;
			if (FromMremapFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToMremapFlags")]
		private static extern int ToMremapFlags (UInt64 value, out MremapFlags rval);

		public static bool TryToMremapFlags (UInt64 value, out MremapFlags rval)
		{
			return ToMremapFlags (value, out rval) == 0;
		}

		public static MremapFlags ToMremapFlags (UInt64 value)
		{
			MremapFlags rval;
			if (ToMremapFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromMsyncFlags")]
		private static extern int FromMsyncFlags (MsyncFlags value, out Int32 rval);

		public static bool TryFromMsyncFlags (MsyncFlags value, out Int32 rval)
		{
			return FromMsyncFlags (value, out rval) == 0;
		}

		public static Int32 FromMsyncFlags (MsyncFlags value)
		{
			Int32 rval;
			if (FromMsyncFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToMsyncFlags")]
		private static extern int ToMsyncFlags (Int32 value, out MsyncFlags rval);

		public static bool TryToMsyncFlags (Int32 value, out MsyncFlags rval)
		{
			return ToMsyncFlags (value, out rval) == 0;
		}

		public static MsyncFlags ToMsyncFlags (Int32 value)
		{
			MsyncFlags rval;
			if (ToMsyncFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromOpenFlags")]
		private static extern int FromOpenFlags (OpenFlags value, out Int32 rval);

		public static bool TryFromOpenFlags (OpenFlags value, out Int32 rval)
		{
			return FromOpenFlags (value, out rval) == 0;
		}

		public static Int32 FromOpenFlags (OpenFlags value)
		{
			Int32 rval;
			if (FromOpenFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToOpenFlags")]
		private static extern int ToOpenFlags (Int32 value, out OpenFlags rval);

		public static bool TryToOpenFlags (Int32 value, out OpenFlags rval)
		{
			return ToOpenFlags (value, out rval) == 0;
		}

		public static OpenFlags ToOpenFlags (Int32 value)
		{
			OpenFlags rval;
			if (ToOpenFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromPathconfName")]
		private static extern int FromPathconfName (PathconfName value, out Int32 rval);

		public static bool TryFromPathconfName (PathconfName value, out Int32 rval)
		{
			return FromPathconfName (value, out rval) == 0;
		}

		public static Int32 FromPathconfName (PathconfName value)
		{
			Int32 rval;
			if (FromPathconfName (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToPathconfName")]
		private static extern int ToPathconfName (Int32 value, out PathconfName rval);

		public static bool TryToPathconfName (Int32 value, out PathconfName rval)
		{
			return ToPathconfName (value, out rval) == 0;
		}

		public static PathconfName ToPathconfName (Int32 value)
		{
			PathconfName rval;
			if (ToPathconfName (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromPollEvents")]
		private static extern int FromPollEvents (PollEvents value, out Int16 rval);

		public static bool TryFromPollEvents (PollEvents value, out Int16 rval)
		{
			return FromPollEvents (value, out rval) == 0;
		}

		public static Int16 FromPollEvents (PollEvents value)
		{
			Int16 rval;
			if (FromPollEvents (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToPollEvents")]
		private static extern int ToPollEvents (Int16 value, out PollEvents rval);

		public static bool TryToPollEvents (Int16 value, out PollEvents rval)
		{
			return ToPollEvents (value, out rval) == 0;
		}

		public static PollEvents ToPollEvents (Int16 value)
		{
			PollEvents rval;
			if (ToPollEvents (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromPosixFadviseAdvice")]
		private static extern int FromPosixFadviseAdvice (PosixFadviseAdvice value, out Int32 rval);

		public static bool TryFromPosixFadviseAdvice (PosixFadviseAdvice value, out Int32 rval)
		{
			return FromPosixFadviseAdvice (value, out rval) == 0;
		}

		public static Int32 FromPosixFadviseAdvice (PosixFadviseAdvice value)
		{
			Int32 rval;
			if (FromPosixFadviseAdvice (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToPosixFadviseAdvice")]
		private static extern int ToPosixFadviseAdvice (Int32 value, out PosixFadviseAdvice rval);

		public static bool TryToPosixFadviseAdvice (Int32 value, out PosixFadviseAdvice rval)
		{
			return ToPosixFadviseAdvice (value, out rval) == 0;
		}

		public static PosixFadviseAdvice ToPosixFadviseAdvice (Int32 value)
		{
			PosixFadviseAdvice rval;
			if (ToPosixFadviseAdvice (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromPosixMadviseAdvice")]
		private static extern int FromPosixMadviseAdvice (PosixMadviseAdvice value, out Int32 rval);

		public static bool TryFromPosixMadviseAdvice (PosixMadviseAdvice value, out Int32 rval)
		{
			return FromPosixMadviseAdvice (value, out rval) == 0;
		}

		public static Int32 FromPosixMadviseAdvice (PosixMadviseAdvice value)
		{
			Int32 rval;
			if (FromPosixMadviseAdvice (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToPosixMadviseAdvice")]
		private static extern int ToPosixMadviseAdvice (Int32 value, out PosixMadviseAdvice rval);

		public static bool TryToPosixMadviseAdvice (Int32 value, out PosixMadviseAdvice rval)
		{
			return ToPosixMadviseAdvice (value, out rval) == 0;
		}

		public static PosixMadviseAdvice ToPosixMadviseAdvice (Int32 value)
		{
			PosixMadviseAdvice rval;
			if (ToPosixMadviseAdvice (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromSeekFlags")]
		private static extern int FromSeekFlags (SeekFlags value, out Int16 rval);

		public static bool TryFromSeekFlags (SeekFlags value, out Int16 rval)
		{
			return FromSeekFlags (value, out rval) == 0;
		}

		public static Int16 FromSeekFlags (SeekFlags value)
		{
			Int16 rval;
			if (FromSeekFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToSeekFlags")]
		private static extern int ToSeekFlags (Int16 value, out SeekFlags rval);

		public static bool TryToSeekFlags (Int16 value, out SeekFlags rval)
		{
			return ToSeekFlags (value, out rval) == 0;
		}

		public static SeekFlags ToSeekFlags (Int16 value)
		{
			SeekFlags rval;
			if (ToSeekFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromSignum")]
		private static extern int FromSignum (Signum value, out Int32 rval);

		public static bool TryFromSignum (Signum value, out Int32 rval)
		{
			return FromSignum (value, out rval) == 0;
		}

		public static Int32 FromSignum (Signum value)
		{
			Int32 rval;
			if (FromSignum (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToSignum")]
		private static extern int ToSignum (Int32 value, out Signum rval);

		public static bool TryToSignum (Int32 value, out Signum rval)
		{
			return ToSignum (value, out rval) == 0;
		}

		public static Signum ToSignum (Int32 value)
		{
			Signum rval;
			if (ToSignum (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromSysconfName")]
		private static extern int FromSysconfName (SysconfName value, out Int32 rval);

		public static bool TryFromSysconfName (SysconfName value, out Int32 rval)
		{
			return FromSysconfName (value, out rval) == 0;
		}

		public static Int32 FromSysconfName (SysconfName value)
		{
			Int32 rval;
			if (FromSysconfName (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToSysconfName")]
		private static extern int ToSysconfName (Int32 value, out SysconfName rval);

		public static bool TryToSysconfName (Int32 value, out SysconfName rval)
		{
			return ToSysconfName (value, out rval) == 0;
		}

		public static SysconfName ToSysconfName (Int32 value)
		{
			SysconfName rval;
			if (ToSysconfName (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromSyslogFacility")]
		private static extern int FromSyslogFacility (SyslogFacility value, out Int32 rval);

		public static bool TryFromSyslogFacility (SyslogFacility value, out Int32 rval)
		{
			return FromSyslogFacility (value, out rval) == 0;
		}

		public static Int32 FromSyslogFacility (SyslogFacility value)
		{
			Int32 rval;
			if (FromSyslogFacility (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToSyslogFacility")]
		private static extern int ToSyslogFacility (Int32 value, out SyslogFacility rval);

		public static bool TryToSyslogFacility (Int32 value, out SyslogFacility rval)
		{
			return ToSyslogFacility (value, out rval) == 0;
		}

		public static SyslogFacility ToSyslogFacility (Int32 value)
		{
			SyslogFacility rval;
			if (ToSyslogFacility (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromSyslogLevel")]
		private static extern int FromSyslogLevel (SyslogLevel value, out Int32 rval);

		public static bool TryFromSyslogLevel (SyslogLevel value, out Int32 rval)
		{
			return FromSyslogLevel (value, out rval) == 0;
		}

		public static Int32 FromSyslogLevel (SyslogLevel value)
		{
			Int32 rval;
			if (FromSyslogLevel (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToSyslogLevel")]
		private static extern int ToSyslogLevel (Int32 value, out SyslogLevel rval);

		public static bool TryToSyslogLevel (Int32 value, out SyslogLevel rval)
		{
			return ToSyslogLevel (value, out rval) == 0;
		}

		public static SyslogLevel ToSyslogLevel (Int32 value)
		{
			SyslogLevel rval;
			if (ToSyslogLevel (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromSyslogOptions")]
		private static extern int FromSyslogOptions (SyslogOptions value, out Int32 rval);

		public static bool TryFromSyslogOptions (SyslogOptions value, out Int32 rval)
		{
			return FromSyslogOptions (value, out rval) == 0;
		}

		public static Int32 FromSyslogOptions (SyslogOptions value)
		{
			Int32 rval;
			if (FromSyslogOptions (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToSyslogOptions")]
		private static extern int ToSyslogOptions (Int32 value, out SyslogOptions rval);

		public static bool TryToSyslogOptions (Int32 value, out SyslogOptions rval)
		{
			return ToSyslogOptions (value, out rval) == 0;
		}

		public static SyslogOptions ToSyslogOptions (Int32 value)
		{
			SyslogOptions rval;
			if (ToSyslogOptions (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromWaitOptions")]
		private static extern int FromWaitOptions (WaitOptions value, out Int32 rval);

		public static bool TryFromWaitOptions (WaitOptions value, out Int32 rval)
		{
			return FromWaitOptions (value, out rval) == 0;
		}

		public static Int32 FromWaitOptions (WaitOptions value)
		{
			Int32 rval;
			if (FromWaitOptions (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToWaitOptions")]
		private static extern int ToWaitOptions (Int32 value, out WaitOptions rval);

		public static bool TryToWaitOptions (Int32 value, out WaitOptions rval)
		{
			return ToWaitOptions (value, out rval) == 0;
		}

		public static WaitOptions ToWaitOptions (Int32 value)
		{
			WaitOptions rval;
			if (ToWaitOptions (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromXattrFlags")]
		private static extern int FromXattrFlags (XattrFlags value, out Int32 rval);

		public static bool TryFromXattrFlags (XattrFlags value, out Int32 rval)
		{
			return FromXattrFlags (value, out rval) == 0;
		}

		public static Int32 FromXattrFlags (XattrFlags value)
		{
			Int32 rval;
			if (FromXattrFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToXattrFlags")]
		private static extern int ToXattrFlags (Int32 value, out XattrFlags rval);

		public static bool TryToXattrFlags (Int32 value, out XattrFlags rval)
		{
			return ToXattrFlags (value, out rval) == 0;
		}

		public static XattrFlags ToXattrFlags (Int32 value)
		{
			XattrFlags rval;
			if (ToXattrFlags (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromPathConf")]
		private static extern int FromPathConf (PathConf value, out Int32 rval);

		[Obsolete ("Use Mono.Unix.Native.PathconfName")]
		public static bool TryFromPathConf (PathConf value, out Int32 rval)
		{
			return FromPathConf (value, out rval) == 0;
		}

		[Obsolete ("Use Mono.Unix.Native.PathconfName")]
		public static Int32 FromPathConf (PathConf value)
		{
			Int32 rval;
			if (FromPathConf (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToPathConf")]
		private static extern int ToPathConf (Int32 value, out PathConf rval);

		[Obsolete ("Use Mono.Unix.Native.PathconfName")]
		public static bool TryToPathConf (Int32 value, out PathConf rval)
		{
			return ToPathConf (value, out rval) == 0;
		}

		[Obsolete ("Use Mono.Unix.Native.PathconfName")]
		public static PathConf ToPathConf (Int32 value)
		{
			PathConf rval;
			if (ToPathConf (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_FromSysConf")]
		private static extern int FromSysConf (SysConf value, out Int32 rval);

		[Obsolete ("Use Mono.Unix.Native.SysconfName")]
		public static bool TryFromSysConf (SysConf value, out Int32 rval)
		{
			return FromSysConf (value, out rval) == 0;
		}

		[Obsolete ("Use Mono.Unix.Native.SysconfName")]
		public static Int32 FromSysConf (SysConf value)
		{
			Int32 rval;
			if (FromSysConf (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

		[DllImport (LIB, EntryPoint="Mono_Posix_ToSysConf")]
		private static extern int ToSysConf (Int32 value, out SysConf rval);

		[Obsolete ("Use Mono.Unix.Native.SysconfName")]
		public static bool TryToSysConf (Int32 value, out SysConf rval)
		{
			return ToSysConf (value, out rval) == 0;
		}

		[Obsolete ("Use Mono.Unix.Native.SysconfName")]
		public static SysConf ToSysConf (Int32 value)
		{
			SysConf rval;
			if (ToSysConf (value, out rval) == -1)
				ThrowArgumentException (value);
			return rval;
		}

	}
}

