using Sandbox;
using System;

namespace Sandbox
{
	public partial class SecretPhrase : Sandbox.Game // addon
	{
		[ConCmd.Client]
		static void bloxwich() // lower chars, because this is console command 
		{
			Client ply = Local.Client;
			
			Log.Info( $"{ply.Name} earned the achievement Secret Phrase" );
		}
	}
}
