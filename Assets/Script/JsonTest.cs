using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System;
using System.IO;

[Serializable]
public class PersonSerializableClassField
{
    public int id;
    public AddressSerializableClassField[] addresses;
}

[Serializable]
public class AddressSerializableClassField
{
    public int zipcode;
    public string address;
}

public class PersonPlaneClassProperty
{
    public int Id { get; set; }
    public AddressPlaneClassProperty[] Addresses { get; set; }
}

public class AddressPlaneClassProperty
{
    public int Zipcode { get; set; }
    public string Address { get; set; }
}



public class InputJson//テキストファイルとして入力されるjsonデータの形式
{
    public string aaa;
    public int bbb;
}


public class JsonTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");

        string inputString = Resources.Load<TextAsset>("input").ToString();//textデータ読み込み Resources内のinput.json


         var target = new PersonPlaneClassProperty
    {
        Id = 200,
        Addresses = new AddressPlaneClassProperty[]
        {
            new AddressPlaneClassProperty{ Zipcode = 2003921, Address = "hoge" },
            new AddressPlaneClassProperty{ Zipcode = 2002955, Address = "fuga" },
        },
    };

    var serialized = JsonConvert.SerializeObject(target);//シリアライズ
    Debug.Log(serialized);

    var deserialized = JsonConvert.DeserializeObject<PersonPlaneClassProperty>(serialized);//デシリアライズ
    Debug.Log(deserialized.ToString());

    InputJson inputJson=  JsonConvert.DeserializeObject<InputJson>(inputString);//入力したファイルから取り出したjsonデータをデシリアライズ
    Debug.Log(inputJson.aaa);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

