Rhinoceros.MVVM 是一个作者基于学习他人或自身理解所编写的一个基本的MVVM框架。


它包含了以下几个关键类
1. 实现了 INotifyPropertyChanged 的 BaseModel以及对应的Code Snippet(快捷键 'rprop'）

2. 继承了 BaseModel 的 BaseModelWidthIsModify，其拥有一个IsModify 属性，用于指明类是否发生过属性值变化

3. 实现了 ICommand 的 RelayCommand 以及 对应的Code Snippet(快捷键 'rcmd')

4. 实现了 ICommand 的 ParamRelayCommand 以及对应的 Code Snippet(快捷键 'rpcmd')


Tips: 
1. 所有的Code Snippet 在卸载掉后自动删除
2. Code Snippet 自动拷贝和删除仅支持 VS2017，VS2019。若未使用支持的VS，那么没有快捷键可用。