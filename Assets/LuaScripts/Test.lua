print("Test.lua")
testNumber = 2
testBool = false
testFloat = 5.5
testString = "lsc"

--通过C#没办法直接获取本地局部变量
local testLocal = 10

--无参无返回
testFunc = function()
	print("无参无返回...")
end


--有参有返回
testFunc2 = function(a)
	print("有参有返回")
	return a + 1
end

--多返回
testFunc3 = function(a)
	print("多返回")
	return 1,2,false,"hehe",a
end

---变长参数
testFunc4 = function(a, ...)
	print("变长参数")
	print(a)
	arg = {...}
	for k,v in pairs(arg) do
		print(k,v)
	end
end

--List
testList = {1,4,3,6,9,5}
testList2 = {"lsc","yyp",66,1,false}

testDict = {
	name = 1,
	age = 2,
	sex = 3,
	school = 4
}

testDict2 = {
	name = "lsc",
	age = 16,
	sex = 1,
	school = "shizhi"
}

testDict3 = {
	["1"] = 1,
	[true] = true,
	[false] = false,
	["sss"] = false
}

