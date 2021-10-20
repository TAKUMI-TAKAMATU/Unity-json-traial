# Unity-json-traial
unity上でのjsonの確認

デフォルトで使用することができるJsonUtilityには多次元配列が使えないなどの問題点がある。よってc#のライブラリであるJson.Netを用いるための環境構築と使用感を確かめる。


できない場合
https://github.com/JamesNK/Newtonsoft.Json
よりライブラリをダウンロード

zip ファイル内の [lib/netstandard2.0] の配下にある Newtonsoft.Json.dllをunity内の[Asserts/Plugins]に入れる

[参考]

JSON.NETでの実装、環境整備について
https://yotiky.hatenablog.com/entry/unity_jsonserializer#JsonNET-NewtonsoftJson

jsonファイルの読み込み
https://memonoana.hatenablog.com/entry/2019/05/22/005823
