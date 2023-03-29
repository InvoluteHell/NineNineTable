<?for($i=1;++$i<10;){for($j=0;$j++<$i;){echo"{$j}x{$i}=".($i*$j).($j!=$i?str_repeat(" ",4-strlen($i*$j)):"");}echo "\n";}
