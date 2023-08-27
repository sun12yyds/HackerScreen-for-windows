# 爱心代码 Love

![Love](1.png)

提供的一个可选本地网页，位于 `html\love.html`，可以显示你们在一起的时长，内容文案可自行修改该文件。

## 1. 修改时间

时间位于第61和62行，设置你们在一起的时间，即可计算过去了多久：

```js
together.setFullYear(2018,2,9);
together.setHours(20,0,0,0);
```

> 注意 `setFullYear` 中的语法：`Date.setFullYear(year, month, day)`

<table>
<tbody><tr>
<th style="width: 22%;">参数</th>
<th>描述</th>
</tr>

<tr>
<td><i>year</i></td>
<td>必需。表示年份的值，允许负值。</td>
</tr>

<tr>
<td><i>month</i></td>
<td>
<p>可选。表示月份的整数。</p>
<p>预期值是 0-11，但允许其他值：</p>

	<ul class="listintable">
	<li>-1 将导致上一年的最后一个月</li>
	<li>12 将导致明年的第一个月</li>
	<li>13 将导致明年的第二个月</li>
	</ul>
</td>
</tr>

<tr>
<td><i>day</i></td>
<td>
<p>可选。整数，表示月中的哪一天。</p>
<p>预期值是 1-31，但允许其他值：</p>

	<ul class="listintable">
	<li>0 将导致上个月的最后一天</li>
	<li>-1 将导致上个月的最后一天的前一天</li>
	</ul>

<p>如果一个月有 31 天：</p>

	<ul class="listintable">
	<li>32 将导致下个月的第一天</li>
	</ul>

<p>如果一个月有 30 天：</p>

	<ul class="listintable">
	<li>32 将导致下个月的第二天</li>
	</ul>
</td>
</tr>
</tbody></table>

> 注意 `setHours` 中的语法：`Date.setHours(hour, min, sec, millisec)`

<table>
<tbody><tr>
<th style="width: 22%;">参数</th>
<th>描述</th>
</tr>

<tr>
<td><i>hour</i></td>
<td>
<p>必需。表示小时的整数。</p>
<p>期望值是 0-23，但允许其他值：</p>

	<ul class="listintable">
	<li>-1 将导致前一天的最后一个小时</li>
	<li>24 将导致第二天的第一个小时</li>
	</ul>
</td>
</tr>

<tr>
<td><i>min</i></td>
<td>
<p>可选。表示分钟的整数。</p>
<p>期望值是 0-59，但允许其他值：</p>

	<ul class="listintable">
	<li>-1 将导致前一小时的最后一分钟</li>
	<li>60 将导致下一小时的第一分钟</li>
	</ul>
</td>
</tr>

<tr>
<td><i>sec</i></td>
<td>
<p>可选。表示秒的整数。</p>
<p>期望值是 0-59，但允许其他值：</p>

	<ul class="listintable">
	<li>-1 将导致前一分钟的最后一秒</li>
	<li>60 将导致下一分钟的第一秒</li>
	</ul>
</td>
</tr>

<tr>
<td><i>millisec</i></td>
<td>
<p>可选。表示毫秒的整数。</p>
<p>期望值为 0-999，但允许其他值：</p>

	<ul class="listintable">
	<li>-1 将导致前一秒的最后一毫秒</li>
	<li>1000 将导致下一秒的第一毫秒</li>
	</ul>
</td>
</tr>
</tbody></table>

## 2. 修改名称

称谓在77和78行，75和76行可以改为你们的纪念时间，比如在一起，求婚等等。

第105、109和110行可修改为时间的说明文案。