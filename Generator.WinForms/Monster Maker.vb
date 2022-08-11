Public Class Monster_Maker
    'Name,CR,XP,Race,Class,MonsterSource,Alignment,Size,Type,SubType,Init,Senses,Aura,AC,AC_Mods,HP,HD,HP_Mods,Saves,Fort,Ref,Will,Save_Mods,DefensiveAbilities,DR,Immune,Resist,SR,Weaknesses,Speed,Speed_Mod,Melee,Ranged,Space,Reach,SpecialAttacks,SpellLikeAbilities,SpellsKnown,SpellsPrepared,SpellDomains,AbilitiyScores,AbilitiyScore_Mods,BaseAtk,CMB,CMD,Feats,Skills,RacialMods,Languages,SQ,Environment,Organization,Treasure,Description_Visual,Group,Source,IsTemplate,SpecialAbilities,Description,FullText,Gender,Bloodline,ProhibitedSchools,BeforeCombat,DuringCombat,Morale,Gear,OtherGear,Vulnerability,Note,CharacterFlag,CompanionFlag,Fly,Climb,Burrow,Swim,Land,TemplatesApplied,OffenseNote,BaseStatistics

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strHold As String
        strHold = "Case """ & TextBox5.Text & """: return """ & ComboBox1.Text & "/" & cmbSize.Text & "/" & cmbEnemyType.Text & "/" & NumericUpDown1.Value & "/" & ComboBox2.Text & "/" & NumericUpDown2.Value & "/" & NumericUpDown3.Value & "/" & NumericUpDown4.Value & "/" & TextBox1.Text & "/" & NumericUpDown5.Value & "/" & NumericUpDown6.Value & "/" & NumericUpDown7.Value & "/" & NumericUpDown9.Value & "/" & NumericUpDown8.Value & "/" & NumericUpDown11.Value & "/" & NumericUpDown10.Value & "/" & TextBox2.Text & "/" & TextBox3.Text & "/" & NumericUpDown12.Value & "/" & TextBox4.Text & """"
        Clipboard.SetText(strHold)

    End Sub

    Private Sub Monster_Maker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class